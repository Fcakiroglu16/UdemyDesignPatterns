using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Adapter.Services
{
    public class AdvanceImageProcessAdapter : IImageProcess
    {
        private readonly IAdvanceImageProcess _advanceImageProcess;

        public AdvanceImageProcessAdapter(IAdvanceImageProcess advanceImageProcess)
        {
            _advanceImageProcess = advanceImageProcess;
        }

        public void AddWatermark(string text, string filename, Stream imageStream)
        {
            _advanceImageProcess.AddWatermarkImage(imageStream, text, $"wwwroot/watermarks/{filename}", Color.FromArgb(128, 255, 255, 255), Color.FromArgb(0, 255, 255, 255));
        }
    }
}