using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisAdminGimnasio.Presentacion.Models.Entidades
{
    public class Usuario
    {
        public string Id { get; set; }
        public string Correo { get; set; }
        public string TokenSesion { get; set; }
    }
}