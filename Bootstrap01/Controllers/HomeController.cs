using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bootstrap01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.title = "I Love Web App";

            List<string> listBook = new List<string>();
            listBook.Add("Davinci code");
            listBook.Add("The lost symbol");
            listBook.Add("Inferno");
            ViewData["ListBook"] = listBook;

            TempData["data1"] = "I am from action 1";
            return RedirectToAction("Read");
            return View();
        }
        public string Read()
        {
            string str;
            str = TempData["data1"].ToString();
            return str;
        }
    }
}