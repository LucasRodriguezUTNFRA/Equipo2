using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class SistemaDeEntradas
    {
        private static List<Usuario> listaUsuarios = new List<Usuario>();

        static SistemaDeEntradas()
        {
            listaUsuarios.Add(new Empleado("pachuli", "pachuli", "Pablo", "Vidal"));
        }

        public static bool LogearUsuario(string nombreUsuario, string contrasenia)
        {
            bool retorno = false;
            foreach (var usuario in listaUsuarios)
            {
                if (nombreUsuario == usuario.nombreUsuario && contrasenia == usuario.Contrasenia)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
    }
}
