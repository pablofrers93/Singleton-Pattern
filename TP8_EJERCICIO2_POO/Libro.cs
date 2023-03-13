using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8_EJERCICIO2_POO
{
    public class Libro: Publicacion
    {
        public int NumeroPaginas { get; set; }

        public Libro(string titulo, float precio, int numeroPaginas):base(titulo, precio)
        {
            NumeroPaginas = numeroPaginas;
        }
    }
}
