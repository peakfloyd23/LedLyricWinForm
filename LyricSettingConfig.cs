using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LedLyricWinForm
{
    public class LyricSettingConfig
    {
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public object font {get; set; }

        public object color { get; set; }


        public static void saveSetting(LyricSettingConfig config)
        {
            var resultJson = JsonSerializer.Serialize(config);
            try
            {
                File.WriteAllText("config.json", resultJson);
            }
            catch
            {

            }
        }

        public static LyricSettingConfig loadConfig(string file)
        {
            try
            {
                var jsonStr = File.ReadAllText(file);
                LyricSettingConfig? config = JsonSerializer.Deserialize<LyricSettingConfig>(jsonStr);
                return config;
            }
            catch
            {

            }
            return null;
        }

        public static Font GetRealFont(JsonElement obj)
        {
            string familyName = obj.GetProperty("FontFamily").GetProperty("Name").GetString();
            string name = obj.GetProperty("Name").GetString();
            float size = obj.GetProperty("Size").GetInt16();
            bool bold = obj.GetProperty("Bold").GetBoolean();
            bool italic = obj.GetProperty("Italic").GetBoolean();
            bool strikeout = obj.GetProperty("Strikeout").GetBoolean();
            bool underline = obj.GetProperty("Underline").GetBoolean();

            FontStyle fontStyle = FontStyle.Regular;
            if (bold) fontStyle |= FontStyle.Bold;
            if (italic) fontStyle |= FontStyle.Italic;
            if (strikeout) fontStyle |= FontStyle.Strikeout;
            if (underline) fontStyle |= FontStyle.Underline;
            Font font = new Font(familyName, size, fontStyle);
            return font;
        }

        public static Color GetColor(JsonElement obj)
        {
            string name = obj.GetProperty("Name").GetString();
            int R = obj.GetProperty("R").GetInt32();
            int G = obj.GetProperty("G").GetInt32();
            int B = obj.GetProperty("B").GetInt32();
            Color color = Color.FromArgb(R,G,B);
            return color;
        }

    }
}
