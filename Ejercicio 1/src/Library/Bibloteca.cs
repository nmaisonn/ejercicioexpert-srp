using System;
using System.Collections.Generic;

namespace SRP
{
    public class Biblioteca
    {
        public List<Estante> Estantes { get; private set; }

        public Biblioteca()
        {
            this.Estantes = new List<Estante>();
        }

        public void AgregarLibro(Libro libro, string sector, string identificador)
        {
            foreach (Estante item in this.Estantes)
            {
                if (item.Identificador == identificador && item.Sector == sector)
                {
                    item.AgregarLibro(libro);
                    return;
                }
            }

            Estante estante = new Estante(sector, identificador);
            estante.AgregarLibro(libro);
            this.Estantes.Add(estante);
        }
    }
}