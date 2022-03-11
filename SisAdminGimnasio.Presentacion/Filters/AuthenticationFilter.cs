using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace SisAdminGimnasio.Presentacion.Filters
{
    public class AuthenticationFilter : ActionFilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            var fil = filterContext;
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            var au = filterContext;
        }
    }
}