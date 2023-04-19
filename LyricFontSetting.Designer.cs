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
            button1 = new Button();
            groupBox2 = new GroupBox();
            Height = new NumericUpDown();
            Width = new NumericUpDown();
            YPosition = new NumericUpDown();
            XPosition = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Height).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Width).BeginInit();
            ((System.ComponentModel.ISupportInitialize)YPosition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)XPosition).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(66, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(633, 316);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "字体和颜色";
            // 
            // button1
            // 
            button1.Location = new Point(232, 62);
            button1.Name = "button1";
            button1.Size = new Size(152, 34);
            button1.TabIndex = 0;
            button1.Text = "选择字体";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Height);
            groupBox2.Controls.Add(Width);
            groupBox2.Controls.Add(YPosition);
            groupBox2.Controls.Add(XPosition);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(66, 478);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(633, 289);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "位置设置";
            // 
            // Height
            // 
            Height.Location = new Point(423, 154);
            Height.Name = "Height";
            Height.Size = new Size(180, 30);
            Height.TabIndex = 11;
            // 
            // Width
            // 
            Width.Location = new Point(98, 154);
            Width.Maximum = new decimal(new int[] { 4000, 0, 0, 0 });
            Width.Name = "Width";
            Width.Size = new Size(180, 30);
            Width.TabIndex = 10;
            // 
            // YPosition
            // 
            YPosition.Location = new Point(423, 63);
            YPosition.Name = "YPosition";
            YPosition.Size = new Size(180, 30);
            YPosition.TabIndex = 9;
            // 
            // XPosition
            // 
            XPosition.Location = new Point(98, 63);
            XPosition.Name = "XPosition";
            XPosition.Size = new Size(180, 30);
            XPosition.TabIndex = 8;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 154);
            label3.Name = "label3";
            label3.Size = new Size(50, 24);
            label3.TabIndex = 4;
            label3.Text = "宽度:";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 63);
            label1.Name = "label1";
            label1.Size = new Size(26, 24);
            label1.TabIndex = 0;
            label1.Text = "X:";
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
            ((System.ComponentModel.ISupportInitialize)Height).EndInit();
            ((System.ComponentModel.ISupportInitialize)Width).EndInit();
            ((System.ComponentModel.ISupportInitialize)YPosition).EndInit();
            ((System.ComponentModel.ISupportInitialize)XPosition).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button4;
        private NumericUpDown Height;
        private NumericUpDown Width;
        private NumericUpDown YPosition;
        private NumericUpDown XPosition;
    }
}