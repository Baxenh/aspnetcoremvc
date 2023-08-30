using Baitap_Tulam_2_QuanLy_Hanghoa.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Baitap_Tulam_2_QuanLy_Hanghoa.Controllers
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

        public IActionResult Gioithieu()
        {
            return View();
        }
        public IActionResult LienHe()
        {
            return View();
        }
        public IActionResult Sanpham()
        {
            return View();
        }
        public IActionResult Dangky()
        {
            return View();
        }
        public IActionResult DangNhap()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}