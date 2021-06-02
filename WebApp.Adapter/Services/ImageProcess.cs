using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Adapter.Services
{
    public class ImageProcess : IImageProcess
    {
        public void AddWatermark(string text, string filename, Stream imageStream)
        {
            using var img = Image.FromStream(imageStream);

            using var graphic = Graphics.FromImage(img);

            var font = new Font(FontFamily.GenericMonospace, 40, FontStyle.Bold, GraphicsUnit.Pixel);

            var textSize = graphic.MeasureString(text, font);

            var color = Color.FromArgb(128, 255, 255, 255);
            var brush = new SolidBrush(color);

            var position = new Point(img.Width - ((int)textSize.Width + 30), img.Height - ((int)textSize.Height + 30));

            graphic.DrawString(text, font, brush, position);

            img.Save("wwwroot/watermarks/" + filename);

            img.Dispose();
            graphic.Dispose();
        }
    }
}