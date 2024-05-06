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
            // Obtener los datos del formulario
            string nombre = txtNombreFPension.Text;
            string descuentoText = txtDescuentoFPension.Text;

            // Validar si el descuento está vacío
            if (string.IsNullOrWhiteSpace(descuentoText))
            {
                MessageBox.Show("Por favor ingrese un valor para el descuento.");
            }
            else if (!decimal.TryParse(descuentoText, out decimal porcentajeDescuento))
            {
                MessageBox.Show("El valor ingresado para el descuento no es válido.");
            }
            else
            {
                // Llamar al método de la capa de negocio para insertar el fondo de pensión
                try
                {
                    CN_FondoPension.InsertarFondoPension(nombre, porcentajeDescuento);

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Fondo de pensión agregado correctamente.");

                    // Limpiar los campos después de guardar
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
