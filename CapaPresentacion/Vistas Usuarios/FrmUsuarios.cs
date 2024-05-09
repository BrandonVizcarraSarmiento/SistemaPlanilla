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
    }
}
