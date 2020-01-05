using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageMagick;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyPractice.DAL;
using MyPractice.Models;
using MyPractice.ViewModels;

namespace MyPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly TestingMyselfContext _context;
        public readonly IWebHostEnvironment _env;
        public HomeController(TestingMyselfContext context,
                              IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(MyFile myFile)
        {
            //FileStream (file saved in local system) - These lines must come first
            string folderPath = Path.Combine(_env.WebRootPath, "images");
            string fileName = myFile.MyFileName.FileName;
            string filePath = Path.Combine(folderPath, fileName);

            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                await myFile.MyFileName.CopyToAsync(fileStream);
            }


            #region Add watermark with System.Drawing
            //using (var bitmap = Bitmap.FromFile(filePath))
            //{
            //    using (var tempBitmap = new Bitmap(bitmap.Width, bitmap.Height))
            //    {
            //        using (Graphics grp = Graphics.FromImage(tempBitmap))
            //        {
            //            grp.DrawImage(bitmap, 0, 0);
            //            bitmap.Dispose();
            //            Brush brush = new SolidBrush(Color.FromArgb(10, 1, 1));
            //            Font font = new System.Drawing.Font("Sofia Pro", 50, FontStyle.Bold, GraphicsUnit.Pixel);
            //            SizeF textSize = grp.MeasureString("testingtestingtestingtestingtestingtestingtestingtestingtesting", font);
            //            Point position = new Point(300, 300);
            //            grp.DrawString("testingtestingtestingtestingtestingtestingtestingtestingtesting", font, brush, position);
            //            tempBitmap.Save(filePath);
            //        }
            //    }
            //}
            #endregion

            #region Crop image with MAGICK.NET
            //using (var image = new MagickImage(filePath))
            //{
            //    image.Crop(image.Width / 2, image.Height / 2);
            //    image.Write(filePath);
            //}
            #endregion

            #region Resize image with MAGICK.NET
            //using (var image = new MagickImage(filePath))
            //{
            //    image.Resize(image.Width / 2, image.Height / 2);
            //    image.Write(filePath);
            //}
            #endregion

            #region Compress image with MAGICK.NET
            //var file = new FileInfo(filePath);
            //var optimizer = new ImageOptimizer();

            //optimizer.Compress(file);
            ////OR
            ////optimizer.LosslessCompress(file);
            //file.Refresh();
            #endregion

            return View();
        }

        public IActionResult SecondPage()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult SecondPage(HomeViewModel homeViewModel)
        {
            //MemoryStream (file not saved in local system)
            #region Uploading images through MemoryStream
            byte[] result = null;

            using (Stream stream = homeViewModel.MyFile.OpenReadStream())
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    stream.CopyTo(memoryStream);
                    result = memoryStream.ToArray();
                }
            }
            #endregion

            Table1 table1 = new Table1
            {
                Name = result
            };

            _context.Table1.Add(table1);
            _context.SaveChanges();

            #region Looking result from MemoryStream
            //StringBuilder stringBuilder = new StringBuilder();

            //foreach (var item in result)
            //{
            //    stringBuilder.Append(item);
            //}

            //return Content(stringBuilder.ToString());
            #endregion

            return View();
        }

        public IActionResult ThirdPage()
        {
            return View(_context.Table1.Find(1));
        }

        public IActionResult TestProcedure()
        {
            var getPhotos = _context.Table1.FromSqlRaw("GetPhotos").ToList();

            return View(getPhotos);
        }
    }
}
