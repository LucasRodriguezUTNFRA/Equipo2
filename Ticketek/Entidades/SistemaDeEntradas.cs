using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class SistemaDeEntradas
    {
        static Usuario usuarioLogueado;

        private static List<Show> listaShows = new List<Show>();
        private static List<Usuario> listaUsuarios = new List<Usuario>();
        private static List<Estadio> listaEstadios = new List<Estadio>();


        static SistemaDeEntradas()
        {
            listaUsuarios.Add(new Empleado("p", "p", "Pablo", "Vidal"));
            CargarEstadios();
            listaShows.Add(new Show(new Artista("duko"), listaEstadios[0], DateTime.Parse("15/10/2022"), 3, 20));
            listaShows.Add(new Show(new Artista("maluma"), listaEstadios[1], DateTime.Parse("12/10/2022"), 3, 15));
            listaShows.Add(new Show(new Artista("maluma2"), listaEstadios[2], DateTime.Parse("16/10/2022"), 3, 30));
            listaShows.Add(new Show(new Artista("duko2"), listaEstadios[3], DateTime.Parse("18/10/2022"), 3,40));
           
        }

        private static void CargarEstadios()
        {
            listaEstadios.Add(new Estadio(15000, "boca"));
            listaEstadios.Add(new Estadio(30000, "river"));
            listaEstadios.Add(new Estadio(5000, "velez"));
            listaEstadios.Add(new Estadio(6000, "nose"));
        }

        public static bool LogearUsuario(string nombreUsuario, string contrasenia)
        {
            bool retorno = false;
            foreach (Usuario usuario in listaUsuarios)
            {
                if (nombreUsuario == usuario.nombreUsuario && contrasenia == usuario.Contrasenia)
                {
                    usuarioLogueado = usuario;
                    retorno = true;
                }
            }
            return retorno;
        }
        public static Usuario NombreUsuario
        {
            get
            {
                return usuarioLogueado;
            }
        }

        public static List<Show> ListaShows { get => listaShows;}
        public static List<Estadio> ListaEstadios { get => listaEstadios;  }

        public static void AgregarShow(Show show)
        {
            listaShows.Add(show);
        }
    }
}
