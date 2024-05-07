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

namespace CapaPresentacion.Vistas_Empleados
{
    public partial class FrmAgregarEmpleado : Form
    {
        public FrmAgregarEmpleado()
        {
            InitializeComponent();
            CargarComboBox();
        }
        private void CargarComboBox()
        {
            try
            {
                // Cargar los datos para cboBanco
                List<Banco> listaBancos = CN_Bancos.ObtenerTodosBancos();
                cboBanco.DataSource = listaBancos;
                cboBanco.DisplayMember = "Nombre";
                cboBanco.ValueMember = "Id";
                // Cargar los datos para cboFondoPension
                List<FondoPension> listaFondosPension = CN_FondoPension.ObtenerTodosFondosPension();
                cboFondoPension.DataSource = listaFondosPension;
                cboFondoPension.DisplayMember = "Nombre";
                cboFondoPension.ValueMember = "Id";
                // Cargar los datos para cboCargo
                List<Cargo> listaCargos = CN_Cargo.ObtenerTodosCargos();
                cboCargo.DataSource = listaCargos;
                cboCargo.DisplayMember = "Nombre";
                cboCargo.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los ComboBox: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos del formulario
                string dnitext = txtDNI.Text.Trim();
                string nombres = txtNombres.Text;
                string apellidos = txtApellidos.Text;
                DateTime fechaInicioContrato = dtpFechaIniciContrato.Value;
                DateTime fechaFinContrato = dtpFechaFinContraton.Value;
                string cuentaBancaria = txtCuenta.Text;
                int idBanco = (int)cboBanco.SelectedValue;
                int idFondoPension = (int)cboFondoPension.SelectedValue;
                int idCargo = (int)cboCargo.SelectedValue;

                CN_Empleados cnEmpleados = new CN_Empleados();
                cnEmpleados.InsertarEmpleado(dnitext, nombres, apellidos, fechaInicioContrato, fechaFinContrato, cuentaBancaria, idBanco, idFondoPension, idCargo);

                MessageBox.Show("Empleado agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarControles();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarControles()
        {
            txtDNI.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCuenta.Clear();
            dtpFechaIniciContrato.Value = DateTime.Now;
            dtpFechaFinContraton.Value = DateTime.Now;
            cboBanco.SelectedIndex = -1;
            cboFondoPension.SelectedIndex = -1;
            cboCargo.SelectedIndex = -1;
        }

        private void btnCancelarEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
