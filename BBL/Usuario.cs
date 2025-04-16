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

		private int _DNI;

		public int DNI
		{
			get { return _DNI; }
			set { _DNI = value; }
		}

		public bool Loguearse (string usuario, string clave)
		{
			DAL.Usuario unLogin = new DAL.Usuario();

			DataTable dt = unLogin.IniciarSesion();

			foreach(DataRow fila in dt.Rows)
			{
				if (fila["usuario"].ToString().Trim() == usuario.Trim() && fila["clave"].ToString().Trim() == clave.Trim())
                {
                    return true;
                }
            }
            return false;
        }
	}
}
