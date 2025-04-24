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
            Console.WriteLine("");
        }

        public IActionResult Privacy()
        {
            return View();
            Console.WriteLine(  "test fitch ");
        }

       
    }
}
