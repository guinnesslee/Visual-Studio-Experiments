﻿using System.Web.Mvc;

namespace Experiments.AspNetMvc3NewFeatures.GlobalActionFilters.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewModel.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
