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
    public partial class FrmEditarEmpleado : Form
    {
        private int id;
        public FrmEditarEmpleado(int id, int dni, string nombres, string apellidos, DateTime fechaInicioContrato, DateTime fechaFinContrato, int cuentaBancaria, string nombreBanco, string FondoPension, string Cargo)
        {
            InitializeComponent();
            CargarComboBox();
            this.id = id;
            txtDNI.Text = dni.ToString();
            txtNombres.Text = nombres;
            txtApellidos.Text = apellidos;
            dtpFechaIniciContrato.Value = fechaInicioContrato;
            dtpFechaFinContraton.Value = fechaFinContrato;
            txtCuenta.Text = cuentaBancaria.ToString();

            // Busca el índice del nombre del banco en la lista
            int indexBanco = cboBanco.FindStringExact(nombreBanco);
            // Establece el índice seleccionado en el ComboBox
            cboBanco.SelectedIndex = indexBanco;

            int indexFondoPension = cboFondoPension.FindStringExact(FondoPension);
            cboFondoPension.SelectedIndex = indexFondoPension;

            int indexCargo = cboCargo.FindStringExact(Cargo);
            cboCargo.SelectedIndex = indexCargo;
        }
        private void CargarComboBox()
        {
            try
            {
                List<Banco> listaBancos = CN_Bancos.ObtenerTodosBancos();
                cboBanco.DataSource = listaBancos;
                cboBanco.DisplayMember = "Nombre";
                cboBanco.ValueMember = "Id";

                List<FondoPension> listaFondosPension = CN_FondoPension.ObtenerTodosFondosPension();
                cboFondoPension.DataSource = listaFondosPension;
                cboFondoPension.DisplayMember = "Nombre";
                cboFondoPension.ValueMember = "Id";

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
        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos del formulario
                string dnitext = txtDNI.Text.Trim();
                string nombres = txtNombres.Text;
                string apellidos = txtApellidos.Text;
                DateTime fechaInicioContrato = dtpFechaIniciContrato.Value;
                DateTime fechaFinContrato = dtpFechaFinContraton.Value;
                string cuentaBancariaText = txtCuenta.Text;
                int idBanco = (int)cboBanco.SelectedValue;
                int idFondoPension = (int)cboFondoPension.SelectedValue;
                int idCargo = (int)cboCargo.SelectedValue;

                // Llamar al método de la capa de negocios para editar el empleado
                CN_Empleados cnEmpleados = new CN_Empleados();
                cnEmpleados.EditarEmpleado(id, dnitext, nombres, apellidos, fechaInicioContrato, fechaFinContrato, cuentaBancariaText, idBanco, idFondoPension, idCargo);

                MessageBox.Show("Empleado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarEmpleado_Click(object sender, EventArgs e)
        {
            txtDNI.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCuenta.Clear();
            dtpFechaIniciContrato.Value = DateTime.Now;
            dtpFechaFinContraton.Value = DateTime.Now;
            cboBanco.SelectedIndex = 0;
            cboFondoPension.SelectedIndex = 0;
            cboCargo.SelectedIndex = 0;
        }

        private void btnCancelarEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
