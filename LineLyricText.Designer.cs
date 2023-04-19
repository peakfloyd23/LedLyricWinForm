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
            lyricLabel = new Label();
            SuspendLayout();
            // 
            // lyricLabel
            // 
            lyricLabel.AutoSize = true;
            lyricLabel.Location = new Point(-1, 43);
            lyricLabel.Name = "lyricLabel";
            lyricLabel.Size = new Size(0, 24);
            lyricLabel.TabIndex = 0;
            // 
            // LineLyricText
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1813, 113);
            ControlBox = false;
            Controls.Add(lyricLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LineLyricText";
            StartPosition = FormStartPosition.Manual;
            Text = "LineLyricText";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lyricLabel;
    }
}