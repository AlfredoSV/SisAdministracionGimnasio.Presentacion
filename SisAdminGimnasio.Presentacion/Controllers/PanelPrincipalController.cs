using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SisAdminGimnasio.Presentacion.Controllers
{
    public class PanelPrincipalController : Controller
    {
        // GET: PanelPrincipal
        public ActionResult Index()
        {
            return View();
        }
    }
}