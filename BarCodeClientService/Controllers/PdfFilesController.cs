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

//using BarCodeLibrary.Respones.SAP.Bank;

namespace BarCodeClientService.Controllers
{
    public class PdfFilesController : Controller
    {

        IHostingEnvironment _hostingEnvironment = null;

        public PdfFilesController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public IActionResult FrmUploadViewPdf(string fileName="")
        {
            FilePdfClass fileObj = new FilePdfClass();
            fileObj.Name = fileName;

            string path = $"{_hostingEnvironment.WebRootPath}\\UploadPDF\\";
            int nId = 1;

            foreach (string pdfPath in Directory.EnumerateFiles(path, "*.pdf"))
            {
                fileObj.Files.Add(new FilePdfClass()
                {
                    FileId = nId++,
                    Name = Path.GetFileName(pdfPath),
                    Path = pdfPath
                });
            }

            return View(fileObj);
        }

        [HttpPost]
        public IActionResult FrmUploadViewPdf(IFormFile file, [FromServices] IHostingEnvironment hostingEnvironment)
        {
            string fileName = $"{hostingEnvironment.WebRootPath}\\UploadPDF\\{file.FileName}";

            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            return FrmUploadViewPdf();
        }

        public IActionResult PDFViewNewTab(string fileName)
        {
            string path = _hostingEnvironment.WebRootPath + "\\file\\" + fileName;
            return File(System.IO.File.ReadAllBytes(path), "application/pdf");
        }

        public IActionResult ApprovePdf()
        {
            return View();
        }

        private const int FontSize = 7;
        private readonly BaseFont Font = BaseFont.CreateFont();
        private readonly BaseColor Color = BaseColor.Red;
        private const int VerticalSpaceBetweenLines = 15;

        public IActionResult Stamp1Pdf()
        {

            //Image Signature
            string iSignature = $"{_hostingEnvironment.WebRootPath}\\Signature\\EMP001.png";
            Stream inputImageStream = new FileStream(iSignature, FileMode.Open, FileAccess.Read, FileShare.Read);



            MemoryStream mmr = new MemoryStream();
            PdfContentByte doc;

            string FilenameX = $"{_hostingEnvironment.WebRootPath}\\UploadPDF\\Draft\\C001-122222-001.pdf";
            PdfReader rd = new PdfReader(FilenameX);
            

            PdfStamper stp = new PdfStamper(rd, mmr);
            AcroFields acf = stp.AcroFields;
            var dc = stp.GetOverContent(1);
            

            var gstate = new PdfGState
            {
                FillOpacity = 0.61f,
                StrokeOpacity = 0.61f
            };
            dc.SaveState();
            dc.SetGState(gstate);
            dc.SetColorFill(Color);
            dc.BeginText();
            dc.SetFontAndSize(Font, FontSize);
            var x = 598;
            var y = 24;
            var lines = new string[] { "Approve1" }
            .Where(line => !string.IsNullOrEmpty(line));
            foreach (var line in lines)
            {
                dc.ShowTextAligned(Element.ALIGN_CENTER, line, x, y, 0);
                y -= VerticalSpaceBetweenLines;
            }
            dc.EndText();
            dc.RestoreState();

            var pdfContentByte = stp.GetOverContent(1);
            Image image = Image.GetInstance(inputImageStream);
            image.ScaleAbsolute(60f, 18f);
            //Position
            image.SetAbsolutePosition(570, 18);
            pdfContentByte.AddImage(image);

            stp.FormFlattening = true;
            stp.Writer.CloseStream = false;
            stp.Close();

            mmr.Seek(0, SeekOrigin.Begin);

            string fileName = "Drawing.pdf";

            string sourcePath = @"D:\UploadPDF\From";
            string targetPath = @"D:\UploadPDF\To";
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);

            string renameFile = fileName.Split('.').First() + "_Approve1." + fileName.Split('.').Last();
            string fullPath = Path.Combine(targetPath, renameFile);

            //File Name
            string fileNameDraft = "C001-122222-001.pdf";
            string reNameDraft = fileNameDraft.Split('.').First() + "_Approve1." + fileNameDraft.Split('.').Last();
            //Folder Draft
            //string folderD = $"{_hostingEnvironment.WebRootPath}\\UploadPDF\\Draft\\";
            //Folder Appr1
            string toPath = $"{_hostingEnvironment.WebRootPath}\\UploadPDF\\Appr1";
            
            //Save To Directory

            System.IO.File.WriteAllBytes(Path.Combine(toPath, reNameDraft), mmr.ToArray());

            //Return Msg
            return Ok("Successfully created PDF document.");
        }

        public IActionResult Appr2(string empId)
        {
            empId = empId + ".png";
            //Image Signature
            string iSignature = $"{_hostingEnvironment.WebRootPath}\\Signature\\{empId}";
            Stream inputImageStream = new FileStream(iSignature, FileMode.Open, FileAccess.Read, FileShare.Read);

            return Ok("Successfully [Sale Approvel]");
        }

    }
}
