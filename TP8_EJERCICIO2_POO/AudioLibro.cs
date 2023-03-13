using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8_EJERCICIO2_POO
{
    public class AudioLibro: Publicacion
    {
        public float Duracion { get; set; }

        public AudioLibro(string titulo, float precio, float duracion):base(titulo, precio)
        {
            Duracion = duracion;
        }
    }
}
