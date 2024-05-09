using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion.Vistas_Usuarios
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            CN_Usuario cnUsuarios = new CN_Usuario();
            dtgvUsuario.DataSource = cnUsuarios.ObtenerUsuariosConRoles();
        }
        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            txtBusquedaUsuario.Text = "";
            foreach (DataGridViewRow row in dtgvUsuario.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario agregarForm = new FrmAgregarUsuario();
            agregarForm.ShowDialog();
            CargarDatos();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dtgvUsuario.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dtgvUsuario.SelectedRows[0].Cells["Id"].Value);
                string nombre = dtgvUsuario.SelectedRows[0].Cells["Nombre"].Value.ToString();
                string correo = dtgvUsuario.SelectedRows[0].Cells["Correo"].Value.ToString();
                string clave = dtgvUsuario.SelectedRows[0].Cells["Clave"].Value.ToString();
                int idRol = Convert.ToInt32(dtgvUsuario.SelectedRows[0].Cells["IdRol"].Value);
                bool estado = Convert.ToBoolean(dtgvUsuario.SelectedRows[0].Cells["Estado"].Value);

                // Abre el formulario para editar usuario
                FrmEditarUsuario editarForm = new FrmEditarUsuario(id, nombre, correo, clave, idRol, estado);
                editarForm.ShowDialog();

                // Recarga los datos después de editar el usuario
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Seleccione un registro para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
