using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ScheduleClock
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists("SCconfig.json"))
            {
                FileExtract("ScheduleClock.SCconfig.json", AppDomain.CurrentDomain.BaseDirectory + "SCconfig.json");
            }
            Location = new Point(JsonReaderInt("上一次打开窗口的位置.X"), JsonReaderInt("上一次打开窗口的位置.Y"));
            if (JsonReaderBool("隐藏窗口模式"))
            {
                FormBorderStyle = FormBorderStyle.None;
                tag = false;
            }
            TopMost = true;
            BackColor = Color.WhiteSmoke;
            TransparencyKey = Color.WhiteSmoke;
        }

        private void Monitor_Tick(object sender, EventArgs e)
        {
            JsonWriter("上一次打开窗口的位置.X", Location.X);
            JsonWriter("上一次打开窗口的位置.Y", Location.Y);
            DateTime time = DateTime.Now;
            string h = time.Hour.ToString();
            string m = time.Minute.ToString();
            if (h.Length != 2) h = "0" + h;
            if (m.Length != 2) m = "0" + m;
            Label1.Text = h.Substring(0, time.Hour.ToString().Length - 1);
            Label2.Text = h.Substring(1, time.Hour.ToString().Length - 1);
            Label3.Text = m.Substring(0, time.Hour.ToString().Length - 1);
            Label4.Text = m.Substring(1, time.Hour.ToString().Length - 1);
            Label5.Text = time.Second.ToString();
            StringBuilder t = new StringBuilder();
            t.Append(Label1.Text);
            t.Append(Label2.Text);
            t.Append(Label3.Text);
            t.Append(Label4.Text);
            if (JsonReaderStr(t.ToString()) != null)
            {
                Label6.Text = string.Format("{1}：{0}", JsonReaderStr(t.ToString()), JsonReaderStr("计划文本前的解释文字"));
            }
            else
            {
                int min = int.MaxValue;
                string minValue = "?";
                if (Label6.Text == "")
                {
                    string[] lines = File.ReadAllLines("SCconfig.json");
                    foreach (string line in lines)
                    {
                        if (!line.Contains("\""))
                        {
                            continue;
                        }
                        else
                        {
                            string[] core = line.Split(new string[] { "\"", "\"" }, StringSplitOptions.None);
                            if (IsNumeric(core[1]))
                            {
                                if (int.Parse(t.ToString()) < int.Parse(core[1]))
                                {
                                    continue;
                                }
                                int D_value = Math.Abs(int.Parse(t.ToString()) - int.Parse(core[1]));
                                if (D_value <= min)
                                {
                                    min = D_value;
                                    minValue = core[1];
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    Label6.Text = string.Format("{1}：{0}", JsonReaderStr(minValue), JsonReaderStr("计划文本前的解释文字"));
                }
                //string f = File.ReadAllText("SCconfig.json");
                //char[] chars = t.ToString().ToCharArray();
                //int i = 0;
                //if (chars[0].ToString() == "0")
                //{
                //    chars[0] = '9';
                //    i = int.Parse(string.Concat(chars));
                //    while (true)
                //    {
                //        int itemp = i - 9000;
                //        if (f.Contains(itemp.ToString()))
                //        {
                //            Label6.Text = string.Format("{1}：{0}", JsonReaderStr(itemp.ToString()), JsonReaderStr("计划文本前的解释文字"));
                //            break;
                //        }
                //        //if (i == 1260)
                //        //{
                //        //    break;
                //        //}
                //        char[] temp = new char[i];
                //        if (temp[2] == '6')
                //        {
                //            temp[2] = '0';
                //            temp[1] = (char)(int.Parse(temp[1].ToString()) + 1);
                //        }
                //        if (temp[1] == '6')
                //        {
                //            temp[1] = '0';
                //            temp[0] = (char)(int.Parse(temp[1].ToString()) + 1);
                //        }
                //    }
                //}
                //else
                //{
                //    i = int.Parse(string.Concat(chars));
                //    while (true)
                //    {
                //        if (f.Contains(i.ToString()))
                //        {
                //            Label6.Text = string.Format("{1}：{0}", JsonReaderStr(i.ToString()), JsonReaderStr("计划文本前的解释文字"));
                //            break;
                //        }
                //        //if (i == 1260)
                //        //{
                //        //    break;
                //        //}
                //        char[] temp = new char[i];
                //        if (temp[2] == '6')
                //        {
                //            temp[2] = '0';
                //            temp[1] = (char)(int.Parse(temp[1].ToString()) + 1);
                //        }
                //        if (temp[1] == '6')
                //        {
                //            temp[1] = '0';
                //            temp[0] = (char)(int.Parse(temp[1].ToString()) + 1);
                //        }
                //    }
                //}
            }
        }

        private static void FileExtract (string fn, string of)
        {
            BufferedStream bs = null;
            FileStream fs = null;
            try
            {
                Assembly a = Assembly.GetExecutingAssembly();
                bs = new BufferedStream(a.GetManifestResourceStream(fn));
                fs = new FileStream(of, FileMode.Create, FileAccess.Write);
                byte[] buffer = new byte[1024];
                int length;
                while ((length = bs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fs.Write(buffer, 0, length);
                }
                fs.Flush();
            }
            finally
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
                if (bs != null)
                {
                    bs.Dispose();
                }
            }
        }

        private static int JsonReaderInt(string keywords)
        {
            StreamReader sr = File.OpenText("SCconfig.json");
            JsonTextReader jtr = new JsonTextReader(sr);
            JObject jo = (JObject)JToken.ReadFrom(jtr);
            int value = (int)jo[keywords];
            sr.Dispose();
            return value;
        }

        private static string JsonReaderStr(string keywords)
        {
            StreamReader sr = File.OpenText("SCconfig.json");
            JsonTextReader jtr = new JsonTextReader(sr);
            JObject jo = (JObject)JToken.ReadFrom(jtr);
            string value = (string)jo[keywords];
            sr.Dispose();
            return value;
        }

        private static bool JsonReaderBool(string keywords)
        {
            StreamReader sr = File.OpenText("SCconfig.json");
            JsonTextReader jtr = new JsonTextReader(sr);
            JObject jo = (JObject)JToken.ReadFrom(jtr);
            bool value = (bool)jo[keywords];
            sr.Dispose();
            return value;
        }

        private static void JsonWriter(string keywords, dynamic newVaelue)
        {
            string str = File.ReadAllText("SCconfig.json");
            dynamic jo = JsonConvert.DeserializeObject(str);
            jo[keywords] = newVaelue;
            File.WriteAllText("SCconfig.json", JsonConvert.SerializeObject(jo, Formatting.Indented));
        }

        private bool IsNumeric(string str)
        {
            if (str == null || str.Length == 0) 
                return false;
            ASCIIEncoding ascii = new ASCIIEncoding();
            byte[] bytestr = ascii.GetBytes(str);

            foreach (byte c in bytestr)
            {
                if (c < 48 || c > 57)
                {
                    return false;
                }
            }
            return true;
        }

        private static bool tag = true;

        private void Item1_Click(object sender, EventArgs e)
        {
            if (tag == true)
            {
                FormBorderStyle = FormBorderStyle.None;
                tag = false;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.FixedSingle;
                tag = true;
            }
        }

        private void Item2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Item3_Click(object sender, EventArgs e)
        {
            Rectangle rect = Screen.GetWorkingArea(this);
            Location = new Point(rect.Width / 3, 0);
        }
    }
}