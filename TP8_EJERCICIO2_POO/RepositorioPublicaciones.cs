using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8_EJERCICIO2_POO
{
    public class RepositorioPublicaciones
    {
        public List<Publicacion> ListaPublicaciones { get; set; }
        private static RepositorioPublicaciones _instancia = null;

        private RepositorioPublicaciones()
        {
            ListaPublicaciones = new List<Publicacion>();
        }
        public static RepositorioPublicaciones GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new RepositorioPublicaciones();
            }
            return _instancia;
        }

        public void AgregarPublicacion(Publicacion publicacion)
        {
            ListaPublicaciones.Add(publicacion);
        }
        public void BorrarPublicacion(Publicacion publicacion)
        {
            ListaPublicaciones.Remove(publicacion);
        }
        public int GetCantidad()
        {
            return ListaPublicaciones.Count();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Publicacion publicacion in ListaPublicaciones)
            {
                sb.AppendLine(($"Titulo: {publicacion.Titulo}").PadRight(35) + ($"Precio: {publicacion.Precio}"));
            }

            return sb.ToString();
        }
    }
}
