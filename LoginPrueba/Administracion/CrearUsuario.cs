using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPrueba.Administracion
{
    public partial class CrearUsuario: Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void v_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            BE.Usuario usuario = new BE.Usuario();

            // Capa entidad
            usuario.Apellido = tboxApellido.Text;
            usuario.Nombre = tboxNombre.Text;
            usuario.Email = tboxEmail.Text;
            usuario.DNI = Convert.ToInt32(nudDNI.Text);
            usuario.Perfil = BE.Usuario.PerfilUsuario.Administrador;
            usuario.UserName = tboxUserName.Text;
            usuario.Clave = tboxClave.Text;

            // Llamar a capa de negocio
            BBL.Usuario logicaUsuario = new BBL.Usuario();

            if (logicaUsuario.CrearUsuario(usuario))
            {
                MessageBox.Show("Usuario creado correctamente");
            }
            else
            {
                MessageBox.Show("Error al crear el usuario");
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

    }
}
