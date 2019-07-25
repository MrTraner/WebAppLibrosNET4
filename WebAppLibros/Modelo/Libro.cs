using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppLibros.Modelo
{
    public class Libro
    {
        public int IdLibro { set; get; }
        public string Titulo { set; get; }
        public string Autor { set; get; }
        public string Descripcion { set; get; }
        public int TotalPaginas { set; get; }
        public double Precio { set; get; }
    }
}