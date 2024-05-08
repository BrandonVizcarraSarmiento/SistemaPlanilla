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
        }
        private void CargarDatos()
        {
            dtgvAsistencia.DataSource = CN_Asistencia.ObtenerTodosAsistencia();
        }

        private void FrmAsistencias_Load_1(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnLimpiarAsistencias_Click(object sender, EventArgs e)
        {
            dtgvAsistencia.Rows.Clear();
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
    }
}
