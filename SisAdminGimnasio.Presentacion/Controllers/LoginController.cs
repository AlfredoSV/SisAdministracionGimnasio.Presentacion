using SisAdminGimnasio.Presentacion.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisAdminGimnasio.Presentacion.Models;

namespace SisAdminGimnasio.Presentacion.Controllers
{
    public class LoginController : Controller
    {

        // GET: Login     
        public ActionResult Ingresar()
        {
            return View(new Usuario());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult ValidarUsuario(Usuario usuarioModelView)
        {
            var usuarioValido = true;

            if (ModelState.IsValid)
            {
                if (usuarioValido)
                {
                    if (usuarioModelView.Recuerdame)
                    {
                        var cookie = new HttpCookie("usuario");
                        cookie.Value = "1244";
                        HttpContext.Response.Cookies.Add(cookie);
                    }
                   
                    return RedirectToAction("Inicio", "Inicio");
                }
            }

            return View("Ingresar",usuarioModelView);
            
        }
    }
}