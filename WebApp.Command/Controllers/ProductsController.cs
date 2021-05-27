using BaseProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Command.Commands;
using WebApp.Command.Models;

namespace WebApp.Command.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppIdentityDbContext _context;

        public ProductsController(AppIdentityDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }

        public async Task<IActionResult> CreateFile(int type)
        {
            var products = await _context.Products.ToListAsync();

            FileCreateInvoker fileCreateInvoker = new();

            EFileType fileType = (EFileType)type;

            switch (fileType)
            {
                case EFileType.Excel:
                    ExcelFile<Product> excelFile = new(products);

                    fileCreateInvoker.SetCommand(new CreateExcelTableActionCommand<Product>(excelFile));

                    break;

                case EFileType.Pdf:
                    PdfFile<Product> pdfFile = new(products, HttpContext);
                    fileCreateInvoker.SetCommand(new CreatePdfTableActionCommand<Product>(pdfFile));
                    break;

                default:
                    break;
            }

            return fileCreateInvoker.CreateFile();
        }
    }
}