using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Command.Commands
{
    public class CreateExcelTableActionCommand<T> : ITableActionCommand
    {
        private readonly ExcelFile<T> _excelFile;

        public CreateExcelTableActionCommand(ExcelFile<T> excelFile)
        {
            _excelFile = excelFile;
        }

        public IActionResult Execute()
        {
            var excelMemoryStream = _excelFile.Create();

            return new FileContentResult(excelMemoryStream.ToArray(), _excelFile.FileType) { FileDownloadName = _excelFile.FileName };
        }
    }
}