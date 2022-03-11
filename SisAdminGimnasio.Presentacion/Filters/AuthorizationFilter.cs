using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SisAdminGimnasio.Presentacion.Filters
{
    public class AuthorizationFilter : ActionFilterAttribute, IAuthorizationFilter
    {
        private string _roles;
        public AuthorizationFilter(string roles)
        {
            _roles = roles;
        }
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            var filt = filterContext;
            var rolesLista = _roles.Trim().Split(',');

        }
    }
}