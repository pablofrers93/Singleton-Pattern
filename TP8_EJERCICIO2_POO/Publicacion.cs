using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8_EJERCICIO2_POO
{
    public class Publicacion
    {
        public string Titulo { get; set; }
        public float Precio { get; set; }

        public Publicacion(string titulo, float precio)
        {
            Titulo = titulo;
            Precio = precio;
        }
    }
}
