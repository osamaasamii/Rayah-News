using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Rayah_News.Models;
using System.Linq;

namespace Rayah_News.Controllers
{
    public class NewsController : Controller
    {
         readonly NewsContext db; // high scope
        //NewsContext db;//>>>
        public NewsController(NewsContext context)
        {
            // dependancy injection
            db = context; //>>>>
      
           
        }
       
        public IActionResult getNewsByCategory (int id)
        {
            Console.WriteLine(" recived id :"+id);
            var results = db.News.Where(x => x.CategoryId == id).ToList();

            return View(results);
        }

    }
}
