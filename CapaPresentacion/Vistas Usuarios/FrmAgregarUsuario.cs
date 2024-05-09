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
    public partial class FrmAgregarUsuario : Form
    {
        private CN_Usuario cnUsuario;
        public FrmAgregarUsuario()
        {
            InitializeComponent();
            cnUsuario = new CN_Usuario();
        }

        private void FrmAgregarUsuario_Load(object sender, EventArgs e)
        {
            CargarRoles();
            CargarEstados();
        }
        private void CargarRoles()
        {
            // Cargar roles en cboRol
            CN_Rol cnRol = new CN_Rol();
            cboRol.DataSource = cnRol.Listar();
            cboRol.DisplayMember = "Descripcion";
            cboRol.ValueMember = "Id";
        }

        private void CargarEstados()
        {
            DataTable dtEstados = new DataTable();
            dtEstados.Columns.Add("Texto");
            dtEstados.Columns.Add("Valor");
            dtEstados.Rows.Add("Activo", "1");
            dtEstados.Rows.Add("Inactivo", "0");
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.DataSource = dtEstados;
        }
        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            string clave = txtClave.Text;
            int idRol = Convert.ToInt32(cboRol.SelectedValue);
            bool estado = cboEstado.SelectedValue.ToString() == "1";
                                                                   
            if (clave != txtConfirmarClave.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, confirme la contraseña correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                cnUsuario.AgregarUsuario(nombre, correo, clave, idRol, estado);

                MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Capturar otras excepciones y mostrar un mensaje genérico de error
                MessageBox.Show("Error al agregar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            txtClave.Clear();
            txtConfirmarClave.Clear();
            cboRol.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
        }

        private void btnLimpiarUsuario_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
