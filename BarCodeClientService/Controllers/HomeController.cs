using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using BarCodeClientService.Models;
using BarCodeLibrary.APICall;
using BarCodeLibrary.Respones.SAP;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BarCodeClientService.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult LoginAsync()
        {
            return View();
        }

        public IActionResult SaleARCreation()
        {
            return View();
        }

        public IActionResult InventoryCreation()
        {
            return View();
        }

        public IActionResult FrmCheckItem()
        {
            return View();
        }
        

        public IActionResult GetEmployeeLogin(string username, string passw0rd)
        {
            var a = API.Read<ResponseGetEmployee>("api/Employee/GetEmployee/" + username + "/" + passw0rd);
            return Ok(a);
        }

        public IActionResult CheckLogin(string username, string passw0rd)
        {
            // Step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(passw0rd);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            //return sb.ToString();
            return Ok("Login Successfully");
        }

        public IActionResult ResetPassw0rd(string username, string passw0rd)
        {
            // Step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(passw0rd);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            //sb.ToString();
            return Ok("Reset Password Successfully");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}