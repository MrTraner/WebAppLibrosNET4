﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WebAppLibros.Modelo;
using WebAppLibros.Acciones;

namespace WebAppLibros.Acceso
{
    public partial class Login : System.Web.UI.Page
    {
        public string Titulo = "Login";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params.Get("Usuario") != null && Request.Params.Get("Contraseña") != null)
            {
                string username = Request.Params.Get("Usuario");
                string password = Request.Params.Get("Contraseña");

                //Response.Write("<script>alert('se ha enviado el formulario por post');</script>");
                //Response.Write("<script>alert('datos recibidos: " + username + ", " + password + "');</script>");

                Usuario usuario = Usuario_Acciones.Login(username, password);

                if (usuario != null)
                {
                    Response.Write("<script>alert('usuario y contraseña correctos');</script>");

                    Session.Add("usuario", usuario);
                }
                else
                {
                    Response.Write("<script>alert('usuario o contraseña incorrectos');</script>");
                }
            }
        }
    }
}