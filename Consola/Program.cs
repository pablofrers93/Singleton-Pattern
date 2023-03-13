using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP8_EJERCICIO2_POO;

namespace Consola
{
    public class Program
    {
        static void Main(string[] args)
        {

            Libro libro1 = new Libro("Fantasmas y serpientes", 8.5f, 500);
            Libro libro2 = new Libro("Poesia contemporanea", 4.5f, 350);

            AudioLibro audiolibro1 = new AudioLibro("English Level 1", 14.5f, 90f);
            AudioLibro audiolibro2 = new AudioLibro("French Level 3", 11.5f, 60f);

            RepositorioPublicaciones.GetInstancia().AgregarPublicacion(libro1);
            RepositorioPublicaciones.GetInstancia().AgregarPublicacion(libro2);
            RepositorioPublicaciones.GetInstancia().AgregarPublicacion(audiolibro1);
            RepositorioPublicaciones.GetInstancia().AgregarPublicacion(audiolibro2);

            Console.WriteLine($"El repositorio tiene: {RepositorioPublicaciones.GetInstancia().GetCantidad()} publicaciones");
            
            Console.WriteLine(RepositorioPublicaciones.GetInstancia().ToString());
            Console.ReadLine();
        }
    }
}
