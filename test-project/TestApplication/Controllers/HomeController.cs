using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using TestApplication.Models;
namespace TestApplication.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewModel model = new ViewModel();
            model.Property = ConfigurationManager.AppSettings["Environment"];
            return View(model);
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
    }
}