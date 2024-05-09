using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Registrase : Form
    {
        public Registrase()
        {
            InitializeComponent();
        }

        private void btnRegistrarte_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreRegistrar.Text;
            string correo = txtCorreoRegistrar.Text;
            string clave = txtClaveRegistrar.Text;
            string confirmarClave = txtConfirmarClaveRegistrar.Text;

            if (clave != confirmarClave)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Agregar el usuario predefinido
                CN_Usuario cnUsuario = new CN_Usuario();
                cnUsuario.AgregarUsuario(nombre, correo, clave, 2, true);

                MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
