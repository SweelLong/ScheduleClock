namespace ScheduleClock
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer Monitor;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label0 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Item1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Item2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Item3 = new System.Windows.Forms.ToolStripMenuItem();
            Monitor = new System.Windows.Forms.Timer(this.components);
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Monitor
            // 
            Monitor.Enabled = true;
            Monitor.Interval = 1000;
            Monitor.Tick += new System.EventHandler(this.Monitor_Tick);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Comic Sans MS", 110F);
            this.Label1.ForeColor = System.Drawing.Color.LightCoral;
            this.Label1.Location = new System.Drawing.Point(-29, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(153, 206);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "1";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Comic Sans MS", 110F);
            this.Label2.ForeColor = System.Drawing.Color.Lime;
            this.Label2.Location = new System.Drawing.Point(74, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(153, 206);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "1";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Comic Sans MS", 110F);
            this.Label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Label3.Location = new System.Drawing.Point(268, 9);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(153, 206);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "1";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Comic Sans MS", 110F);
            this.Label4.ForeColor = System.Drawing.Color.Gold;
            this.Label4.Location = new System.Drawing.Point(386, 9);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(153, 206);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "1";
            // 
            // Label0
            // 
            this.Label0.AutoSize = true;
            this.Label0.Font = new System.Drawing.Font("Comic Sans MS", 100F);
            this.Label0.ForeColor = System.Drawing.Color.Aquamarine;
            this.Label0.Location = new System.Drawing.Point(191, 9);
            this.Label0.Name = "Label0";
            this.Label0.Size = new System.Drawing.Size(118, 186);
            this.Label0.TabIndex = 1;
            this.Label0.Text = ":";
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Item3,
            this.Item1,
            this.Item2});
            this.Menu.Name = "contextMenuStrip1";
            this.Menu.Size = new System.Drawing.Size(137, 70);
            // 
            // Item1
            // 
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(180, 22);
            this.Item1.Text = "调整窗口";
            this.Item1.Click += new System.EventHandler(this.Item1_Click);
            // 
            // Item2
            // 
            this.Item2.Name = "Item2";
            this.Item2.Size = new System.Drawing.Size(180, 22);
            this.Item2.Text = "退出";
            this.Item2.Click += new System.EventHandler(this.Item2_Click);
            // 
            // Icon
            // 
            this.Icon.ContextMenuStrip = this.Menu;
            this.Icon.Icon = ((System.Drawing.Icon)(resources.GetObject("Icon.Icon")));
            this.Icon.Text = "ScheduleClock";
            this.Icon.Visible = true;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Comic Sans MS", 25F);
            this.Label5.Location = new System.Drawing.Point(12, 205);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(0, 47);
            this.Label5.TabIndex = 2;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(74, 220);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(0, 24);
            this.Label6.TabIndex = 3;
            // 
            // Item3
            // 
            this.Item3.Name = "Item3";
            this.Item3.Size = new System.Drawing.Size(180, 22);
            this.Item3.Text = "移至正上方";
            this.Item3.Click += new System.EventHandler(this.Item3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 279);
            this.Controls.Add(this.Label0);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScheduleClock";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label0;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Item1;
        private System.Windows.Forms.NotifyIcon Icon;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.ToolStripMenuItem Item2;
        private System.Windows.Forms.ToolStripMenuItem Item3;
    }
}

