using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebAppLibros.BaseDeDatos
{
    public class Conexion
    {
        //SQL Server
        private SqlConnection Con;
        private string NombreServidor = "localhost";
        private string NombreBaseDeDatos = "WebAppLibros";
        private string DatosConexion;

        public Conexion()
        {
            DatosConexion = "Data Source=" + NombreServidor + ";Initial Catalog=" + NombreBaseDeDatos + ";Integrated Security=True;";
            Con = new SqlConnection(DatosConexion);
        }

        public void Abrir()
        {
            Con.Open();
        }

        public void Cerrar()
        {
            Con.Close();
        }

        public SqlConnection GetConexion()
        {
            return Con;
        }
    }
}