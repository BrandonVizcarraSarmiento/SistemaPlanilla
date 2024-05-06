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

namespace CapaPresentacion.Vistas_FondoPension
{
    public partial class FrmAgregarFondoPension : Form
    {
        public FrmAgregarFondoPension()
        {
            InitializeComponent();
        }

        private void btnGuardarFPension_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreFPension.Text;
            string descuentoText = txtDescuentoFPension.Text;

            try
            {
                CN_FondoPension.InsertarFondoPension(nombre, descuentoText);

                MessageBox.Show("Fondo de pensión agregado correctamente.");

                LimpiarCampos();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar guardar el fondo de pensión: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txtNombreFPension.Text = "";
            txtDescuentoFPension.Text = "";
        }

        private void btnLimpiarFPension_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCancelarFPension_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
