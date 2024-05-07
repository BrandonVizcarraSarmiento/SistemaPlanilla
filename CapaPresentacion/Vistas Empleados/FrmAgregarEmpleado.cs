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

                // Cargar los datos para cboFondoPension
                List<FondoPension> listaFondosPension = CN_FondoPension.ObtenerTodosFondosPension();
                cboFondoPension.DataSource = listaFondosPension;
                cboFondoPension.DisplayMember = "Nombre";
                cboFondoPension.ValueMember = "Id";

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
                int dni = int.Parse(txtDNI.Text);
                string nombres = txtNombres.Text;
                string apellidos = txtApellidos.Text;
                DateTime fechaInicioContrato = dtpFechaIniciContrato.Value;
                DateTime fechaFinContrato = dtpFechaFinContraton.Value;
                string cuentaBancaria = txtCuenta.Text;
                int idBanco = (int)cboBanco.SelectedValue; // Suponiendo que el ValueMember de cboBanco es el Id del banco
                int idFondoPension = (int)cboFondoPension.SelectedValue; // Suponiendo que el ValueMember de cboFondoPension es el Id del fondo de pension
                int idCargo = (int)cboCargo.SelectedValue; // Suponiendo que el ValueMember de cboCargo es el Id del cargo

                // Insertar el nuevo empleado
                CN_Empleados cnEmpleados = new CN_Empleados();
                cnEmpleados.InsertarEmpleado(dni, nombres, apellidos, fechaInicioContrato, fechaFinContrato, cuentaBancaria, idBanco, idFondoPension, idCargo);

                // Mostrar mensaje de éxito
                MessageBox.Show("Empleado agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los controles del formulario
                LimpiarControles();
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
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
    }
}
