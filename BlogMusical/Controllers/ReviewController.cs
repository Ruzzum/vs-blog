using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMusical.Controllers
{
    public class ReviewController : Controller
    {
         [HttpGet]
        public ActionResult AdmReview()
        {
            return View();
        }
    }
}