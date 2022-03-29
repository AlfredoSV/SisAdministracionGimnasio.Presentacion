using SisAdminGimnasio.Presentacion.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisAdminGimnasio.Presentacion.Models;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;

namespace SisAdminGimnasio.Presentacion.Controllers
{
    public class LoginController : Controller
    {

        // GET: Login     
        public ActionResult Ingresar()
        {
            return View(new UsuarioViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<ActionResult> ValidarUsuarioAsync(UsuarioViewModel usuarioModelView)
        {
            var urlAuth = "https://localhost:44316/api/UsuarioAuth/UsuarioAuth";
            var json= "{\"CorreoUsuario\":\"prueba123@outlook.com\",\"ContrasenaUsuario\":\"prueba123\"}";
            try
            {

                if (ModelState.IsValid)
                {
                    var cliente = new HttpClient();
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    
                    var peticion = await cliente.PostAsync(urlAuth,content);
                    
                    if (peticion.IsSuccessStatusCode)
                    {
                        var res = await peticion.Content.ReadAsStringAsync();

                        if (usuarioModelView.Recuerdame)
                        {
                            var cookie = new HttpCookie("usuario");
                            cookie.Value = "1244";
                            HttpContext.Response.Cookies.Add(cookie);

                        }
                        HttpContext.Session.Add("usuarioSess", Guid.NewGuid());
                        return RedirectToAction("Inicio", "Inicio");
                    }

                }

            }
            catch (Exception e)
            {

                return View("Error");
            }

            return View("Ingresar", usuarioModelView);

        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult NuevoUsuario()
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult GuardarNuevoUsuario()
        {

            return null;
        }



    }
}