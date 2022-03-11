using SisAdminGimnasio.Presentacion.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SisAdminGimnasio.Presentacion.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Ingresar()
        {
            return View();
        }

        [HttpPost]
        
        public ActionResult ValidarUsuario()
        {
            var cookie = new HttpCookie("usuario");
            cookie.Value = "1244";
            HttpContext.Response.Cookies.Add(cookie);
            return RedirectToAction("Inicio","Inicio");
        }
    }
}