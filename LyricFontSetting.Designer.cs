namespace LedLyricWinForm
{
    partial class LyricFontSetting
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(66, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(633, 316);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "字体和颜色";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(66, 478);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(633, 289);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "位置设置";
            // 
            // button1
            // 
            button1.Location = new Point(232, 62);
            button1.Name = "button1";
            button1.Size = new Size(152, 34);
            button1.TabIndex = 0;
            button1.Text = "选择字体";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(232, 142);
            button2.Name = "button2";
            button2.Size = new Size(152, 34);
            button2.TabIndex = 1;
            button2.Text = "选择颜色";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 63);
            label1.Name = "label1";
            label1.Size = new Size(26, 24);
            label1.TabIndex = 0;
            label1.Text = "X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 63);
            label2.Name = "label2";
            label2.Size = new Size(25, 24);
            label2.TabIndex = 1;
            label2.Text = "Y:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(443, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 30);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 154);
            label3.Name = "label3";
            label3.Size = new Size(50, 24);
            label3.TabIndex = 4;
            label3.Text = "宽度:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(141, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 30);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 160);
            label4.Name = "label4";
            label4.Size = new Size(50, 24);
            label4.TabIndex = 6;
            label4.Text = "高度:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(443, 151);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 30);
            textBox4.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(455, 951);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 6;
            button3.Text = "确定";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(587, 951);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 7;
            button4.Text = "取消";
            button4.UseVisualStyleBackColor = true;
            // 
            // LyricFontSetting
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 1040);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "LyricFontSetting";
            Text = "LyricFontSetting";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button4;
    }
}