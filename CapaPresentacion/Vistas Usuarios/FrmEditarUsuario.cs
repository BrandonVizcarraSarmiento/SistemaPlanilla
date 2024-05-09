using CapaEntidad;
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

namespace CapaPresentacion.Vistas_Usuarios
{
    public partial class FrmEditarUsuario : Form
    {
        private int idUsuario;
        public FrmEditarUsuario(int id, string nombre, string correo, string clave, int idRol, bool estado)
        {
            InitializeComponent();
            idUsuario = id;
            txtNombre.Text = nombre;
            txtCorreo.Text = correo;
            txtClave.Text = clave;

            // Cargar roles en cboRol
            CN_Rol cnRol = new CN_Rol();
            cboRol.DataSource = cnRol.Listar();
            cboRol.DisplayMember = "Descripcion";
            cboRol.ValueMember = "Id";

            // Cargar estados en cboEstado
            Dictionary<string, bool> estados = new Dictionary<string, bool>{{ "Activo", true },{ "Inactivo", false }};
            cboEstado.DataSource = new BindingSource(estados, null);
            cboEstado.DisplayMember = "Key";
            cboEstado.ValueMember = "Value";

            // Seleccionar el rol y estado correspondiente al usuario
            cboRol.SelectedValue = idRol;
            cboEstado.SelectedValue = estado;
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string clave = txtClave.Text.Trim();
            int idRol = Convert.ToInt32(cboRol.SelectedValue);
            bool estado = cboEstado.SelectedValue.ToString() == "1";

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                CN_Usuario cnUsuario = new CN_Usuario();
                cnUsuario.EditarUsuario(idUsuario, nombre, correo, clave, idRol, estado);
                MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarUsuario_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            txtClave.Clear();
            txtConfirmarClave.Clear();
            cboRol.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
