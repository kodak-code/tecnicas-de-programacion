using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPrueba
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = tboxUsuario.Text;
            string clave = tboxClave.Text;

            // Instanciamos un obj de tipo Usuario
            BBL.Usuario unLogin = new BBL.Usuario();

            if (unLogin.Loguearse(usuario, clave))
            {
                Form formularioCrearUsuario = new Administracion.CrearUsuario();
                formularioCrearUsuario.Show();
            } else
            {
                MessageBox.Show("Error al iniciar sesion");
            }

        }
    }
}
