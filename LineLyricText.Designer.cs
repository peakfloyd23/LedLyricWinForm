namespace LedLyricWinForm
{
    partial class LineLyricText
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
            lyricLine = new TextBox();
            SuspendLayout();
            // 
            // lyricLine
            // 
            lyricLine.Location = new Point(-2, -4);
            lyricLine.Name = "lyricLine";
            lyricLine.Size = new Size(801, 30);
            lyricLine.TabIndex = 0;
            // 
            // LineLyricText
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 24);
            ControlBox = false;
            Controls.Add(lyricLine);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LineLyricText";
            Text = "LineLyricText";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lyricLine;


        public void setLineTextBoxValue(string value)
        {
            this.lyricLine.Text = value;
        }

        public void Close()
        {
            this.Dispose();
        }
    }
}