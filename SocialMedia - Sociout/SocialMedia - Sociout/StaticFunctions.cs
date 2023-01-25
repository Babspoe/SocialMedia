using dbLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace SocialMedia___Sociout
{
    public static class StaticFunctions
    {

        public static Image ByteArrayToImage(byte[] bytes)
        {
            if(bytes != null) 
            {
                using (var ms = new MemoryStream(bytes))
                {
                    return Image.FromStream(ms);
                }
            }
            return null;
        }

        public static byte[] ImageToByteArray(Image imageIn)
        {
            if(imageIn != null)
            {
                using (var ms = new MemoryStream())
                {
                    imageIn.Save(ms, imageIn.RawFormat);
                    return ms.ToArray();
                }
            }
            else
            {
                return new byte[0];
            }

        }

        private static List<string> colors = new List<string>
        {
            "#800080",
            "#FF0000",
            "#00FF00",
            "#0000FF",
            "#FFFF00",
            "#FFA500",
        };
        static Random rnd = new Random();

        public static Image GetImage(string text)
        {
            int height = 32;
            int width = 32;

            var randomText = text[0].ToString() + text[1].ToString();

            var fonts = new[] { "Verdana" };
            float orientationAngle = rnd.Next(0, 359);

            var index0 = rnd.Next(0, fonts.Length);
            var familyName = fonts[index0];


            using (var bmpOut = new Bitmap(width, height))
            {
                Graphics g = Graphics.FromImage(bmpOut);

                SizeF size = g.MeasureString(randomText, new Font(familyName, 12));

                int x = Convert.ToInt32((width / 2) - (size.Width / 2));
                int y = Convert.ToInt32((height / 2) - (size.Height / 2));



                LinearGradientBrush gradientBrush = new LinearGradientBrush(new Rectangle(0, 0, width, height),
                    ColorTranslator.FromHtml(colors[rnd.Next(colors.Count)]), ColorTranslator.FromHtml(colors[rnd.Next(colors.Count)]), orientationAngle);
                g.FillRectangle(gradientBrush, 0, 0, width, height);
                g.DrawString(randomText, new Font(familyName, 12), new SolidBrush( ColorTranslator.FromHtml("#FFFFFF")), x, y);
                MemoryStream ms = new MemoryStream();
                bmpOut.Save(ms, ImageFormat.Png);
                byte[] bmpBytes = ms.GetBuffer();
                bmpOut.Dispose();
                ms.Close();


                using (MemoryStream fileStream = new MemoryStream(bmpBytes))
                {
                    return Image.FromStream(fileStream);
                }

            }
        }

    }
}
