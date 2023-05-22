using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMvc.Models;
namespace DemoMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Book()
        {
            ViewBag.Message = "Book descriptions";
            // var Book = new Book() { Id = 1 ,Name="Asha" };
            var model = new List<Book>() { new Book { Id = 1, Name = "abc" },
                         new Book{Id=2,Name="xyz"} };

           // model.Add(new Book {Id=1, Name = "MU" });
           // model.Add(new Book{Id=2, Name = "Chelsea" });
            

            return View(model);
        }
    }
}