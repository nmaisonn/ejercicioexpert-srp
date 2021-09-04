using System;
using System.Collections.Generic;

namespace SRP
{
    public class Estante
    {
        public List<Libro> Libros { get; private set; }
        public string Sector { get; private set; }
        public string Identificador { get; private set; }

        public Estante(string sector, string identificador)
        {
            this.Libros = new List<Libro>();
            this.Sector = sector;
            this.Identificador = identificador;
        }

        public void AgregarLibro(Libro libro)
        {
            this.Libros.Add(libro);
        }
    }
}