using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMusical.Controllers
{
    public class LyricsController : Controller
    {
         [HttpGet]
        public ActionResult AdmLyrics()
        {
            return View();
        }
    }
}