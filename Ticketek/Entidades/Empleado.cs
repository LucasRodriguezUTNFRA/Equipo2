using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Usuario
    {
        public Empleado(string usuario, string contrasenia, string nombre, string apellido) : base(usuario, contrasenia, nombre, apellido)
        {

        }
    }
}
