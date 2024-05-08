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

namespace CapaPresentacion.Vistas_Planillas
{
    public partial class FrmPlanillas : Form
    {
        public FrmPlanillas()
        {
            InitializeComponent();
            CargarComboBoxMeses();
            CargarComboBoxAños();
        }
        private void CargarComboBoxMeses()
        {
            // Agregar los números de los meses al ComboBox, del 1 al 12
            for (int mes = 1; mes <= 12; mes++)
            {
                cmbBoxMesPlanilla.Items.Add(mes);
            }
        }
        private void CargarComboBoxAños()
        {
            // Obtener el año actual
            int añoActual = DateTime.Now.Year;

            // Agregar los años al ComboBox, por ejemplo, desde el año actual hasta 10 años atrás
            for (int año = añoActual; año >= añoActual - 10; año--)
            {
                cmbBoxAñoPlanilla.Items.Add(año);
            }
        }
        private void btnCargarPlanilla_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener mes y año seleccionados en los ComboBox
                int mes = Convert.ToInt32(cmbBoxMesPlanilla.SelectedItem);
                int ano = Convert.ToInt32(cmbBoxAñoPlanilla.SelectedItem);

                // Instanciar la clase de la capa de negocio
                CN_Planilla cnPlanilla = new CN_Planilla();

                // Obtener los datos de la planilla
                DataTable planilla = cnPlanilla.ObtenerSalariosNetos(mes, ano);

                // Mostrar los datos en un DataGridView u otro control apropiado en tu formulario
                // Por ejemplo, si tienes un DataGridView llamado dtgvPlanilla:
                dtgvPlanilla.DataSource = planilla;
            }
            catch (Exception ex)
            {
                // Manejar la excepción, por ejemplo, mostrando un mensaje de error al usuario
                MessageBox.Show("Error al cargar la planilla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
