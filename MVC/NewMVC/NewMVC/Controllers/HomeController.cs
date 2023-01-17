using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NewMVC.Controllers
{
    public class HomeController : Controller
    {



        //public string Name()
        //{
        //    return "Amruta";
        //}

        //public string Details()
        //{
        //    return "Details";
        //}
        //public string Index(string id, string name)
        //{
        //    return "Hello, "+ name + "id = "+id;
        //}
        public ActionResult Index()
        {
            ViewBag.Countries = new List<string>()
            {
                "India",
                "US",
                "UK",
                "Canada"

            };
            return View();
        }

    }
}
