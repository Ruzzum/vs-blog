﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMusical.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Inicio()
        {
            ViewBag.hola = "";

            return View();
        }

    }
}