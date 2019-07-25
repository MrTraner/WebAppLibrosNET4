using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppLibros.Modelo
{
    public class Usuario
    {
        public int IdUsuario { set; get; }
        public string Nombre { set; get; }
        public string Apellidos { set; get; }
        public string Correo { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Rol { set; get; }
    }
}