using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class Usuario
    {
        public List<BE.Usuario> Listar()
        {

            Conexion conexion = new Conexion();


            List<BE.Usuario> usuarios = new List<BE.Usuario>();
            DataTable dt = conexion.LeerPorComando("SELECT * FROM [Universidad].[dbo].[Usuario]");

            foreach (DataRow fila in dt.Rows)
            {
                BE.Usuario unUsuario = new BE.Usuario();

                unUsuario.UserName = fila["usuario"].ToString();
                unUsuario.Clave = fila["clave"].ToString();
                unUsuario.Email = "unCorreo@gmai.com";
                unUsuario.DNI = int.Parse(fila["dni"].ToString());

                usuarios.Add(unUsuario);
            }

            return usuarios;
        }

        public void Crear(BE.Usuario usuario)
        {
            Conexion conexion = new Conexion();
            conexion.EscribirPorComando("INSERT INTO [dbo].[Usuario] ([Nombre], [Apellido], [usuario] ,[clave], [dni], [perfil]) values ('" + usuario.Nombre + "', '" + usuario.Apellido + "', '" + usuario.UserName + "', '" + usuario.Clave + 
                "', 321, '1')");

        }
    }
}
