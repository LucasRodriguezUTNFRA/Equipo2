using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estadio
    {
        public int capacidadMaxima;
        string nombre;

        public Estadio(int capacidadMaxima, string nombre)
        {
            this.capacidadMaxima = capacidadMaxima;
            this.nombre = nombre;
        }
        public override string ToString()
        {
            return this.nombre;
        }
    }
}
