using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL
{
    
    public class Usuario
    {

        public bool CrearUsuario(BE.Usuario usuario)
        {
            DAL.Usuario dalUsuario = new DAL.Usuario();
            dalUsuario.Crear(usuario);

            return true;
        }

        /// <summary>
        /// Valida el usuario y clave con los datos en la bd
        /// </summary>
        /// <param name="usuario">Nombre del usuario pasado por parametro</param>
        /// <param name="clave">Clave del usuario pasado por parametro</param>
        /// <returns></returns>

        public bool Loguearse (string usuario, string clave)
		{
			DAL.Usuario dalUsuario = new DAL.Usuario();

			List<BE.Usuario> usuarios = dalUsuario.Listar();

            foreach (BE.Usuario unUsuario in usuarios)
            {
                if(unUsuario.Clave == clave.Trim() && unUsuario.UserName == usuario.Trim())
                {
                    return true;
                }
            }

            return false;
        }
	}
}
