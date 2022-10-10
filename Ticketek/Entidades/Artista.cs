using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Artista
    {
        private string nombre;

        public Artista(string nombre)
        {
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return nombre;
        }
    }

}
