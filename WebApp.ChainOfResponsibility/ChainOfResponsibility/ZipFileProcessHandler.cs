using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ChainOfResponsibility.ChainOfResponsibility
{
    public class ZipFileProcessHandler<T> : Processhandler
    {
        public override object handle(object o)
        {
            var excelMemoryStream = o as MemoryStream;

            excelMemoryStream.Position = 0;

            using (var zipStream = new MemoryStream())
            {
                using (var archive = new ZipArchive(zipStream, ZipArchiveMode.Create))
                {
                    var zipFile = archive.CreateEntry($"{typeof(T).Name}.xlsx");

                    using (var zipEntry = zipFile.Open())
                    {
                        excelMemoryStream.CopyTo(zipEntry);
                    }
                }
                return base.handle(zipStream);
            }
        }
    }
}