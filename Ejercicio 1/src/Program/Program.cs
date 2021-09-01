using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca bibliotecaUCU = new Biblioteca();
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");

            bibliotecaUCU.AgregarLibro(libro1, "A", "7");
            bibliotecaUCU.AgregarLibro(libro2, "B", "3");

            Console.WriteLine(bibliotecaUCU.Estantes[1].Libros[0].Titulo);
        }
    }
}
