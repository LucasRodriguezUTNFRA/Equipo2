using System;

namespace Entidades
{
    public abstract class Usuario
    {
        private string _usuario;
        private string _contrasenia;
        private string _nombre;
        private string _apellido;

        protected Usuario(string usuario, string contrasenia, string nombre, string apellido)
        {
            _usuario = usuario;
            _contrasenia = contrasenia;
            _nombre = nombre;
            _apellido = apellido;
        }

        public string nombreUsuario { get => _usuario; set => _usuario = value; }
        public string Contrasenia { get => _contrasenia; set => _contrasenia = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }

        //public bool ChequearPassword();
    }
}
