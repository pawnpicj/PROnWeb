using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.IO;

using BarCodeClientService.Models;

using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using BarCodeLibrary.APICall;
using Newtonsoft.Json;

namespace BarCodeClientService.Controllers
{
    public class DrawingController : Controller
    {

        IHostingEnvironment _hostingEnvironment = null;

        public DrawingController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}


        public IActionResult CreateDrawing()
        {
            return View();
        }



        //[HttpGet]
        //public IActionResult CreateDrawing(string fileName = "")
        //{
        //    FilePdfClass fileObj = new FilePdfClass();
        //    fileObj.Name = fileName;

        //    string path = $"{_hostingEnvironment.WebRootPath}\\DrawingFile\\";
        //    int nId = 1;

        //    foreach (string pdfPath in Directory.EnumerateFiles(path, "*.pdf"))
        //    {
        //        fileObj.Files.Add(new FilePdfClass()
        //        {
        //            FileId = nId++,
        //            Name = Path.GetFileName(pdfPath),
        //            Path = pdfPath
        //        });
        //    }

        //    return View(fileObj);
        //}

        [HttpPost]
        public IActionResult CreateDrawing(IFormFile file, [FromServices] IHostingEnvironment hostingEnvironment, IFormCollection form)
        {
            //string fileName = $"{hostingEnvironment.WebRootPath}\\DrawingFile\\Draft\\{file.FileName}";
            string fileUpload = file.FileName;

            string inputDocNum = form["DocNum"];
            string inputDateCurrent = form["DateCurrent"];
            string inputCreateBy = form["CreateBy"];
            string inputReamrks = form["Remarks"];

            string reNameDraft = inputDocNum + "." + fileUpload.Split('.').Last();

            string toPath = $"{_hostingEnvironment.WebRootPath}\\DrawingFile\\Draft\\"+ reNameDraft;
            using (FileStream fileStream = System.IO.File.Create(toPath))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }

            DrawingData ddata  = new DrawingData
            {
                DocNum = inputDocNum,
                DateCurrent = inputDateCurrent,
                CreateBy = inputCreateBy,
                Remarks = inputReamrks,
                FileName = reNameDraft
            };

            string sendjson = JsonConvert.SerializeObject(ddata, Formatting.Indented);
            Console.WriteLine(sendjson);

            //var a = API.PostWithReturn<ResponseInventoryCounting>("api/InventoryCounting/SendInventoryCounting", sendjson);

            return Ok("Successfully created PDF document.");
        }


        internal class DrawingData
        {
            public string DocNum { get; set; }
            public string DateCurrent { get; set; }
            public string CreateBy { get; set; }
            public string Remarks { get; set; }
            public string FileName { get; set; }
        }

    }
}
