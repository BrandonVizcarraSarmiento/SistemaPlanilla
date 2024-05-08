using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;


namespace CapaPresentacion.Vistas_Conceptos
{
    public partial class FrmAgregarConceptos : Form
    {
        public FrmAgregarConceptos()
        {
            InitializeComponent();
            // Agregar opciones al ComboBox
            cmbTipoConceptos.Items.AddRange(new string[] { "Ingreso", "Egreso", "Deduccion" });
            // Establecer el índice seleccionado por defecto
            cmbTipoConceptos.SelectedIndex = 0;
        }

        private void btnGuardarConceptos_Click(object sender, EventArgs e)
        {
            
            string codigo = txtCodigoConceptos.Text;
            string nombre = txtNombreConceptos.Text;
            string tipo = cmbTipoConceptos.Text; 

            try
            {
                
                CN_Conceptos.InsertarConcepto(codigo, nombre, tipo);

                MessageBox.Show("Concepto agregado correctamente.");

                LimpiarCampos();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar guardar el concepto: " + ex.Message);
            }
        }

        private void btnLimpiarConceptos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCancelarConceptos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtCodigoConceptos.Text = "";
            txtNombreConceptos.Text = "";
            cmbTipoConceptos.SelectedIndex = 0; // Establecer el índice seleccionado por defecto en el ComboBox
        }
    }
}
