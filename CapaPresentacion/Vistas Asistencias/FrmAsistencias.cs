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
using System.Windows.Documents;
using System.Windows.Forms;

namespace CapaPresentacion.Vistas_Asistencias
{
    public partial class FrmAsistencias : Form
    {
        public FrmAsistencias()
        {
            InitializeComponent();
            CargarComboBoxMeses();
            CargarComboBoxAños();
        }
        private void CargarComboBoxMeses()
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                cmbBoxMesAsistencia.Items.Add(mes);
            }
        }
        private void CargarComboBoxAños()
        {
            int añoActual = DateTime.Now.Year;

            for (int año = añoActual; año >= añoActual - 10; año--)
            {
                cmbBoxAñoAsistencia.Items.Add(año);
            }
        }
        private void FrmAsistencias_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            try
            {
                CN_Asistencia cnAsistencia = new CN_Asistencia();
                DataTable dtAsistencia = cnAsistencia.ObtenerDatosAsistencia();
                dtgvAsistencia.DataSource = dtAsistencia;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de asistencia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLimpiarAsistencias_Click(object sender, EventArgs e)
        {
            if (dtgvAsistencia.SelectedRows.Count > 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow selectedRow = dtgvAsistencia.SelectedRows[0];

                // Elimina la fila seleccionada
                dtgvAsistencia.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para limpiar.");
            }
        }
        private void btnGuardarAsistencias_Click(object sender, EventArgs e)
        {
            if (dtgvAsistencia.SelectedRows.Count > 0)
            {
                // Pregunta al usuario si realmente desea guardar o actualizar el registro
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea guardar o actualizar este registro?", "Confirmar Guardar/Actualizar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow selectedRow = dtgvAsistencia.SelectedRows[0];

                    // Crear un objeto Asistencia y asignarle los valores desde la fila seleccionada
                    Asistencia asistencia = new Asistencia();
                    asistencia.Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    asistencia.Mes = Convert.ToInt32(selectedRow.Cells["Mes"].Value);
                    asistencia.Ano = Convert.ToInt32(selectedRow.Cells["Ano"].Value);
                    asistencia.DiasLaborados = Convert.ToInt32(selectedRow.Cells["DiasLaborados"].Value);
                    asistencia.DiasNoLaborados = Convert.ToInt32(selectedRow.Cells["DiasNoLaborados"].Value);
                    asistencia.DiasEfectivos = Convert.ToInt32(selectedRow.Cells["DiasEfectivos"].Value);

                    // Aquí puedes asignar la propiedad oEmpleado si es necesario
                    asistencia.oEmpleado = new Empleado(); // Ejemplo de inicialización de oEmpleado

                    // Llamar al método para guardar o actualizar la asistencia
                    CN_Asistencia.GuardarOActualizarAsistencia(asistencia);

                    // Volver a cargar los datos en el DataGridView (opcional, si es necesario refrescar la vista)
                    CargarDatos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro para guardar o actualizar.");
            }
        }
        private void btnCargarAsistencias_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el mes y año seleccionados en los ComboBox
                int mesSeleccionado = Convert.ToInt32(cmbBoxMesAsistencia.SelectedItem);
                int añoSeleccionado = Convert.ToInt32(cmbBoxAñoAsistencia.SelectedItem);

                // Llamar al método para obtener los datos de asistencia filtrados por mes y año
                CN_Asistencia cnAsistencia = new CN_Asistencia();
                DataTable dtAsistencia = cnAsistencia.ObtenerDatosAsistenciaPorMesYAño(mesSeleccionado, añoSeleccionado);
                // Verificar si se encontraron datos
                if (dtAsistencia.Rows.Count == 0)
                {
                    // Mostrar un mensaje indicando que no se encontraron datos
                    MessageBox.Show("No se encontraron datos para el mes " + mesSeleccionado + " y año " + añoSeleccionado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Mostrar los datos en el DataGridView
                dtgvAsistencia.DataSource = dtAsistencia;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de asistencia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}