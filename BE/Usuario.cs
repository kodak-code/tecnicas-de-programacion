using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {

        public enum PerfilUsuario
        {
            Administrador = 1,
            Profesor = 2,
            Alumno = 3
        }

        private PerfilUsuario _perfilUsuario;

        public PerfilUsuario Perfil
        {
            get { return _perfilUsuario; }
            set { _perfilUsuario = value; }
        }


        private string _userName;
        public string UserName

        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _clave;

        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }


        private int _DNI;

        public int DNI
        {
            get { return _DNI; }
            set { _DNI = value; }
        }

    }
}
