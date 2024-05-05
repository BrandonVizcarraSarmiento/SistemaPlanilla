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
            try
            {
                // Obtener los datos del formulario
                string nombre = txtNombreFPension.Text;
                decimal porcentajeDescuento = decimal.Parse(txtDescuentoFPension.Text);

                // Llamar al método de la capa de negocio para insertar el fondo de pensión
                CN_FondoPension.InsertarFondoPension(nombre, porcentajeDescuento);

                // Mostrar mensaje de éxito
                MessageBox.Show("Fondo de pensión agregado correctamente.");

                // Limpiar los campos después de guardar
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar fondo de pensión: " + ex.Message);
            }
        }
        // Método para limpiar los campos del formulario
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
