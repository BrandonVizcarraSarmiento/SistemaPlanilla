using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string clave = txtClave.Text;

            if (!string.IsNullOrEmpty(correo) && !string.IsNullOrEmpty(clave))
            {
                CN_Usuario cnUsuario = new CN_Usuario();
                Usuario usuario = cnUsuario.ValidarUsuario(correo, clave);

                if (usuario != null)
                {
                    Inicio formInicio = new Inicio(usuario);
                    formInicio.Show();
                    this.Hide();
                    formInicio.FormClosing += frm_Cerrar;
                }
                else
                {
                    MessageBox.Show("Correo o contraseña incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese el correo y la contraseña");
            }
        }
        private void frm_Cerrar(object sender, FormClosingEventArgs e)
        {
            txtCorreo.Text = "";
            txtClave.Text = "";
            this.Show();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registrase formRegistrase = new Registrase();
            formRegistrase.Show();
            this.Hide();
            formRegistrase.FormClosing += frm_Cerrar;
        }
    }
}
