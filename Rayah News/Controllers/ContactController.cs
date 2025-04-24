
using Microsoft.AspNetCore.Mvc;
using Rayah_News.Models;

namespace Rayah_News.Controllers
{
   
    public class ContactController : Controller
    {
        private readonly NewsContext db; // high scope
        //NewsContext db;//>>>
        public ContactController( NewsContext context)
        {
           // dependancy injection
           db = context; //>>>>
        }
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult SaveContact(ContactUS model)
        {
         
            db.ContactUs.Add(model);
            db.SaveChanges();
            return View();
        }
    }
}
