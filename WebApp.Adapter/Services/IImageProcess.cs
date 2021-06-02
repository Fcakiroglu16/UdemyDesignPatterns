using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Adapter.Services
{
    public interface IImageProcess
    {
        void AddWatermark(string text, string filename, Stream imageStream);
    }
}