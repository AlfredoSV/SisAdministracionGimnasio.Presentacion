using SisAdminGimnasio.Presentacion.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SisAdminGimnasio.Presentacion.Controllers
{
    [AuthenticationFilter]
    public class InicioController : Controller
    {
        [HttpGet]
        public ActionResult Inicio()
        {
            return View();
        }


        [HttpGet]
        [AuthorizationFilter]
        public ActionResult Entrenadores()
        {
            return Content("Hollaaaaa");
        }
    }
}