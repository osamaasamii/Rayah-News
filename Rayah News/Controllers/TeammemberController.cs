using Microsoft.AspNetCore.Mvc;
using Rayah_News.Models;

namespace Rayah_News.Controllers
{
    public class TeammemberController : Controller
    {
        private readonly NewsContext db; // high scope
        //NewsContext db;//>>>
        public TeammemberController(NewsContext context)
        {
            // dependancy injection
            db = context; //>>>>
        }
        public IActionResult OurTeam()
        {
           
            
            return View();
        }
    }
}
