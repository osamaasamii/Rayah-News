using Microsoft.AspNetCore.Mvc;
using Rayah_News.Models;

namespace Rayah_News.Controllers
{
    public class CategoryController : Controller
    {

        NewsContext db;
        public CategoryController(NewsContext context)
        {
            db = context;
        }


        public IActionResult Index()
        {
         var result =   db.Categories.ToList();
            return View(result);
        }
    }
}
