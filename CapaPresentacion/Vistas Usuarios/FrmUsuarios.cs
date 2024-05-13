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
            cboBusquedaUsuario.Items.Add("Nombre");
            cboBusquedaUsuario.Items.Add("Correo");
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
            cboBusquedaUsuario.SelectedIndex = -1;
            CargarDatos();
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

                FrmEditarUsuario editarForm = new FrmEditarUsuario(id, nombre, correo, clave, idRol, estado);
                editarForm.ShowDialog();

                CargarDatos();
            }
            else
            {
                MessageBox.Show("Seleccione un registro para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dtgvUsuario.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dtgvUsuario.SelectedRows[0].Cells["Id"].Value);

                if (MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CN_Usuario cnUsuarios = new CN_Usuario();
                    cnUsuarios.EliminarUsuario(id);
                    MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            string tipoBusqueda = cboBusquedaUsuario.SelectedItem.ToString();
            string valorBusqueda = txtBusquedaUsuario.Text.Trim();

            if (string.IsNullOrEmpty(valorBusqueda))
            {
                MessageBox.Show("Por favor, ingrese un valor para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CN_Usuario cnUsuarios = new CN_Usuario();
            DataTable dtResultado = cnUsuarios.BuscarUsuario(tipoBusqueda == "Nombre" ? valorBusqueda : null, tipoBusqueda == "Correo" ? valorBusqueda : null);

            if (dtResultado.Rows.Count > 0)
            {
                dtgvUsuario.DataSource = dtResultado;
            }
            else
            {
                MessageBox.Show("No se encontraron usuarios que coincidan con la búsqueda.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
