namespace clock
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新天气ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.输入城市ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.刷新频率ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.设置颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.bing每日壁纸ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开启炫彩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.锁定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Mistral", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(53, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "时间";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(59, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "日期";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(58, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "天气";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新天气ToolStripMenuItem,
            this.输入城市ToolStripMenuItem,
            this.刷新频率ToolStripMenuItem,
            this.设置颜色ToolStripMenuItem,
            this.bing每日壁纸ToolStripMenuItem,
            this.开启炫彩ToolStripMenuItem,
            this.锁定ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 180);
            // 
            // 刷新天气ToolStripMenuItem
            // 
            this.刷新天气ToolStripMenuItem.Name = "刷新天气ToolStripMenuItem";
            this.刷新天气ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.刷新天气ToolStripMenuItem.Text = "刷新天气";
            this.刷新天气ToolStripMenuItem.Click += new System.EventHandler(this.刷新天气ToolStripMenuItem_Click);
            // 
            // 输入城市ToolStripMenuItem
            // 
            this.输入城市ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.输入城市ToolStripMenuItem.Name = "输入城市ToolStripMenuItem";
            this.输入城市ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.输入城市ToolStripMenuItem.Text = "输入城市";
            this.输入城市ToolStripMenuItem.Click += new System.EventHandler(this.输入城市ToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            // 
            // 刷新频率ToolStripMenuItem
            // 
            this.刷新频率ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2});
            this.刷新频率ToolStripMenuItem.Name = "刷新频率ToolStripMenuItem";
            this.刷新频率ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.刷新频率ToolStripMenuItem.Text = "刷新频率";
            this.刷新频率ToolStripMenuItem.Click += new System.EventHandler(this.刷新频率ToolStripMenuItem_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox2_KeyDown);
            this.toolStripTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox2_KeyPress);
            // 
            // 设置颜色ToolStripMenuItem
            // 
            this.设置颜色ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox3});
            this.设置颜色ToolStripMenuItem.Name = "设置颜色ToolStripMenuItem";
            this.设置颜色ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.设置颜色ToolStripMenuItem.Text = "设置颜色";
            this.设置颜色ToolStripMenuItem.Click += new System.EventHandler(this.设置颜色ToolStripMenuItem_Click);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox3.Text = "RGB值以点分隔";
            this.toolStripTextBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox3_KeyDown);
            this.toolStripTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox3_KeyPress);
            // 
            // bing每日壁纸ToolStripMenuItem
            // 
            this.bing每日壁纸ToolStripMenuItem.Name = "bing每日壁纸ToolStripMenuItem";
            this.bing每日壁纸ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.bing每日壁纸ToolStripMenuItem.Text = "bing每日壁纸";
            this.bing每日壁纸ToolStripMenuItem.Click += new System.EventHandler(this.bing每日壁纸ToolStripMenuItem_Click);
            // 
            // 开启炫彩ToolStripMenuItem
            // 
            this.开启炫彩ToolStripMenuItem.Name = "开启炫彩ToolStripMenuItem";
            this.开启炫彩ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.开启炫彩ToolStripMenuItem.Text = "开启炫彩";
            this.开启炫彩ToolStripMenuItem.Click += new System.EventHandler(this.开启炫彩ToolStripMenuItem_Click);
            // 
            // 锁定ToolStripMenuItem
            // 
            this.锁定ToolStripMenuItem.Name = "锁定ToolStripMenuItem";
            this.锁定ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.锁定ToolStripMenuItem.Text = "锁定";
            this.锁定ToolStripMenuItem.Click += new System.EventHandler(this.锁定ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(261, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "城市";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(442, 482);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(950, 0);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "h";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 刷新天气ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 输入城市ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 锁定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开启炫彩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新频率ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem 设置颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripMenuItem bing每日壁纸ToolStripMenuItem;
    }
}

