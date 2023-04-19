using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.Distributions;


namespace LedLyricWinForm
{
    public partial class LyricFontSetting : Form
    {
        public LyricFontSetting()
        {
            InitializeComponent();
        }

        private Font font;

        private Color color;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.saveSettings(this.font);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowColor = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.font = dlg.Font;
                this.color = dlg.Color;
            }

        }


        private void saveSettings(Font selectedFont)
        {
            LyricSettingConfig config = new LyricSettingConfig();
            config.XPosition = (int)this.XPosition.Value;
            config.YPosition = (int)this.YPosition.Value;
            config.Width = (int)this.Width.Value;
            config.Height = (int)this.Height.Value;
            config.font = selectedFont;
            config.color = this.color;
            try
            {
                LyricSettingConfig.saveSetting(config);
            }
            catch
            {

            }
        }
    }
}
