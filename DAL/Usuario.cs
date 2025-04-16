using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Usuario
    {
        public DataTable IniciarSesion()
        {
            Conexion conexion = new Conexion();

            DataTable dt = conexion.LeerPorComando("SELECT * FROM [Universidad].[dbo].[Usuario]");

            return dt;
        }
        
    }
}
