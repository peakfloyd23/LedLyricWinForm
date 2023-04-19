using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedLyricWinForm
{
    public partial class LineLyricText : Form
    {
        public LineLyricText()
        {
            InitializeComponent();
        }


        public void setLineTextBoxValue(string value)
        {
            this.lyricLabel.Text = value;
        }

        public void Close()
        {
            this.Dispose();
        }

        public void setTextBoxFont(Font font)
        {
            this.lyricLabel.Font = font;
        }

        public void setTextColor(Color color)
        {
            this.lyricLabel.ForeColor = color;
        }

        public void setTextBoxPosition(Point position)
        {
            this.lyricLabel.Location = position;
        }

        public void setTextBoxSize(Size size)
        {
            this.lyricLabel.Size = size;
        }
    }
}
