using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SisAdminGimnasio.Presentacion.Models
{
    public class UsuarioViewModel
    {
        [Required(ErrorMessage = "Ingresar un usuario")]
        public string UsuarioC { get; set; }

        [Required(ErrorMessage = "Ingresar un contrasenia")]
        public string Contrasenia { get; set; }
        public bool Recuerdame { get; set; }


    }
}