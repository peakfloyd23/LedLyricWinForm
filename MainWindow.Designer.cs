namespace LedLyricWinForm
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            文件ToolStripMenuItem = new ToolStripMenuItem();
            加载字幕文件ToolStripMenuItem = new ToolStripMenuItem();
            字幕显示设置ToolStripMenuItem = new ToolStripMenuItem();
            字幕窗口i设置ToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 文件ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1178, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            文件ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 加载字幕文件ToolStripMenuItem, 字幕显示设置ToolStripMenuItem, 字幕窗口i设置ToolStripMenuItem });
            文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            文件ToolStripMenuItem.Size = new Size(62, 28);
            文件ToolStripMenuItem.Text = "文件";
            // 
            // 加载字幕文件ToolStripMenuItem
            // 
            加载字幕文件ToolStripMenuItem.Name = "加载字幕文件ToolStripMenuItem";
            加载字幕文件ToolStripMenuItem.Size = new Size(223, 34);
            加载字幕文件ToolStripMenuItem.Text = "加载字幕文件";
            加载字幕文件ToolStripMenuItem.Click += 加载字幕文件ToolStripMenuItem_Click;
            // 
            // 字幕显示设置ToolStripMenuItem
            // 
            字幕显示设置ToolStripMenuItem.Name = "字幕显示设置ToolStripMenuItem";
            字幕显示设置ToolStripMenuItem.Size = new Size(223, 34);
            字幕显示设置ToolStripMenuItem.Text = "字幕显示设置";
            字幕显示设置ToolStripMenuItem.Click += 字幕显示设置ToolStripMenuItem_Click;
            // 
            // 字幕窗口i设置ToolStripMenuItem
            // 
            字幕窗口i设置ToolStripMenuItem.Name = "字幕窗口i设置ToolStripMenuItem";
            字幕窗口i设置ToolStripMenuItem.Size = new Size(223, 34);
            字幕窗口i设置ToolStripMenuItem.Text = "字幕窗口i设置";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 214);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1175, 500);
            textBox1.TabIndex = 1;
            textBox1.CursorChanged += textBox1_CursorChanged;
            textBox1.KeyUp += textBox1_KeyUp;
            // 
            // button1
            // 
            button1.Location = new Point(37, 70);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "播放字幕";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(177, 70);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(112, 34);
            button2.TabIndex = 3;
            button2.Text = "关闭字幕";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 744);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            Text = "LED字幕系统";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 加载字幕文件ToolStripMenuItem;
        private ToolStripMenuItem 字幕显示设置ToolStripMenuItem;
        private ToolStripMenuItem 字幕窗口i设置ToolStripMenuItem;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}