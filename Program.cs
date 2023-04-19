using System.Text.Json;
using System.Text.Json.Serialization;


namespace LedLyricWinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());

            //var jsonStr = "{\"XPosition\":0,\"YPosition\":0,\"Width\":100,\"Height\":60,\"font\":{\"Size\":22,\"Style\":0,\"Bold\":false,\"Italic\":false,\"Strikeout\":false,\"Underline\":false,\"FontFamily\":{\"Name\":\"Microsoft YaHei UI\"},\"Name\":\"Microsoft YaHei UI\",\"Unit\":3,\"GdiCharSet\":134,\"GdiVerticalFont\":false,\"OriginalFontName\":null,\"SystemFontName\":\"\",\"IsSystemFont\":false,\"Height\":56,\"SizeInPoints\":22}}";
            //var config = JsonSerializer.Deserialize<LyricSettingConfig>(jsonStr);
            //JsonElement jsonElement = (JsonElement) config.font;
            //Font font = LyricSettingConfig.GetRealFont(jsonElement);
            //Console.WriteLine(config);

        }
    }
}