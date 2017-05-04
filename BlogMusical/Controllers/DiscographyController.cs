using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMusical.Controllers
{
    public class DiscographyController : Controller
    {
        [HttpGet]
        public ActionResult Viewer()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Admin()
        {
            return View();
        }

    }
}