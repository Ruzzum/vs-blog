using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMusical.Controllers
{
    public class AdmnistradorController : Controller
    {
        #region  "Administracion del Blog"
        [HttpGet]
        public ActionResult AdmBlog()
        {
            return View();
        }
        #endregion

        #region  "Subir Discografias"
        [HttpGet]
        public ActionResult UpdateDiscography()
        {
            return View();
        }
        #endregion

        #region  "Subir Reseñas"
        [HttpGet]
        public ActionResult UpdateReview()
        {
            return View();
        }
        #endregion

        #region  "Subir Letras de Canciones"
        [HttpGet]
        public ActionResult UpdateLyrics()
        {
            return View();
        }
        #endregion

        #region  "Subir Noticias"
        [HttpGet]
        public ActionResult UpdateNews()
        {
            return View();
        }
        #endregion
    }
}