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



namespace CapaPresentacion.Vistas_Conceptos
{
    public partial class FrmEditarConceptos : Form
    {
        private int IdConcepto;

        public FrmEditarConceptos(int id, string codigo, string nombre, string tipo)
        {
            InitializeComponent();
            IdConcepto = id;
            txtCodigoConceptos.Text = codigo;
            txtNombreConceptos.Text = nombre;
            // Agregar las opciones al ComboBox
            cmbTipoConceptos.Items.Add("Ingreso");
            cmbTipoConceptos.Items.Add("Egreso");
            cmbTipoConceptos.Items.Add("Deduccion");
            // Seleccionar el valor recibido como tipo
            cmbTipoConceptos.SelectedItem = tipo;
        }

        private void btnGuardarEditConceptos_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoConceptos.Text;
            string nombre = txtNombreConceptos.Text;
            string tipo = cmbTipoConceptos.Text;

            try
            {
                CN_Conceptos.EditarConcepto(IdConcepto, codigo, nombre, tipo);
                MessageBox.Show("Concepto editado correctamente.");
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar editar el concepto: " + ex.Message);
            }
        }

        private void btnLimpiarConceptos_Click(object sender, EventArgs e)
        {
            txtCodigoConceptos.Text = "";
            txtNombreConceptos.Text = "";
            cmbTipoConceptos.SelectedIndex = -1; // Limpiar el ComboBox
        }

        private void btnCancelarConceptos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEditarConceptos_Load(object sender, EventArgs e)
        {

        }
    }
}
