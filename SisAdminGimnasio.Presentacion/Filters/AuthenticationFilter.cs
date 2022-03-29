using SisAdminGimnasio.Presentacion.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Web.Routing;

namespace SisAdminGimnasio.Presentacion.Filters
{
    public class AuthenticationFilter : ActionFilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            //var sesion = Guid.Parse(filterContext.HttpContext.Session["sesion_usuario"].ToString());
            var existeUsuario = true;

            if (existeUsuario)
            {
                //filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Login", action = "Ingresar" }));

            }



        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            var au = filterContext;
        }
    }
}