using Microsoft.AspNetCore.Mvc;
using Rayah_News.Models;
using System.Diagnostics;

namespace Rayah_News.Controllers
{
    public class HomeController : Controller
    {
       

       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
