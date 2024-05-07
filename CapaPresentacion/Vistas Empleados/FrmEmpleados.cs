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
using CapaEntidad;
using CapaPresentacion.Vistas_Empleados;

namespace CapaPresentacion.Vistas_Empleados
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
            // Agregar opciones al ComboBox de criterio de búsqueda
            cboOpcionBuscar.Items.Add("DNI");
            cboOpcionBuscar.Items.Add("Nombres");
            cboOpcionBuscar.Items.Add("Apellidos");
            cboOpcionBuscar.Items.Add("Cargo");

            // Establecer la opción predeterminada
            cboOpcionBuscar.SelectedIndex = 0;
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            CN_Empleados cnEmpleados = new CN_Empleados();
            dtgvEmpleado.DataSource = cnEmpleados.MostrarEmpleados();
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FrmAgregarEmpleado agregarForm = new FrmAgregarEmpleado();
            agregarForm.ShowDialog();
            CargarDatos();
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            if (dtgvEmpleado.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dtgvEmpleado.SelectedRows[0].Cells["Id"].Value);
                int dni = Convert.ToInt32(dtgvEmpleado.SelectedRows[0].Cells["DNI"].Value);
                string nombres = dtgvEmpleado.SelectedRows[0].Cells["Nombres"].Value.ToString();
                string apellidos = dtgvEmpleado.SelectedRows[0].Cells["Apellidos"].Value.ToString();
                DateTime fechaInicioContrato = Convert.ToDateTime(dtgvEmpleado.SelectedRows[0].Cells["FechaInicioContrato"].Value);
                DateTime fechaFinContrato = Convert.ToDateTime(dtgvEmpleado.SelectedRows[0].Cells["FechaFinContrato"].Value);
                int cuentaBancaria = Convert.ToInt32(dtgvEmpleado.SelectedRows[0].Cells["CuentaBancaria"].Value);
                string nombreBanco = dtgvEmpleado.SelectedRows[0].Cells["NombreBanco"].Value.ToString();
                string nombreFondoPension = dtgvEmpleado.SelectedRows[0].Cells["FondoPension"].Value.ToString(); // Asegúrate de que el nombre de la columna sea correcto
                string nombreCargo = dtgvEmpleado.SelectedRows[0].Cells["Cargo"].Value.ToString();

                // Abre el formulario para editar empleado
                FrmEditarEmpleado editarForm = new FrmEditarEmpleado(id, dni, nombres, apellidos, fechaInicioContrato, fechaFinContrato, cuentaBancaria, nombreBanco, nombreFondoPension, nombreCargo);
                editarForm.ShowDialog();

                // Recarga los datos después de editar el empleado
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Seleccione un registro para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dtgvEmpleado.SelectedRows.Count > 0)
            {
                // Pregunta al usuario si realmente desea eliminar el registro
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este empleado?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    // Obtiene el id del empleado seleccionado
                    int id = Convert.ToInt32(dtgvEmpleado.SelectedRows[0].Cells["Id"].Value);

                    // Llama al método para eliminar el empleado
                    CN_Empleados cnEmpleados = new CN_Empleados();
                    cnEmpleados.EliminarEmpleado(id);

                    // Vuelve a cargar los datos en el DataGridView
                    CargarDatos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para eliminar.");
            }
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            // Obtener el criterio de búsqueda seleccionado del ComboBox
            string criterio = cboOpcionBuscar.SelectedItem.ToString();

            // Obtener el término de búsqueda ingresado en el TextBox
            string busqueda = txtBuscarEmpleado.Text;

            // Realizar la búsqueda de empleados
            try
            {
                CN_Empleados cnEmpleados = new CN_Empleados();
                DataTable resultados = cnEmpleados.BuscarEmpleado(criterio, busqueda);

                if (resultados.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron empleados que coincidan con la búsqueda.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dtgvEmpleado.DataSource = resultados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
