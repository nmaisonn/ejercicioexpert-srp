using System;

namespace SRP
{
    public class Libro
    {
        /* No cumple con el patron SRP ya que la clase libro tiene la responsabilidad de conocer al libro y su ubicacion.
            Entonces tiene mas de una responsabilidad.
        Consideramos que cumple con le patron Expet porque la clase Libro tiene toda la informacion, por lo que es
            la unica que puede cumplir con la responsabilidad sin importar de si el tener toda la informacion es
            correcto.
        /*Implementariamos una clase Biblioteca y una clase Estante para separar las responsabilidades de conocer 
            la informacion del libro y su ubicación.
        La clase libro:Conoce la inforamcion del libro.
        La clase estante:Almacena los libros.
        La clase Biblioteca:Conoce la informacion de los estantes.
        */ 

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
