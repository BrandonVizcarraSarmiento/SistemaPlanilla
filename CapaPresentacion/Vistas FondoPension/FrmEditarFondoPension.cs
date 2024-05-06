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

namespace CapaPresentacion.Vistas_FondoPension
{
    public partial class FrmEditarFondoPension : Form
    {
        private int IdFondoPension;
        public FrmEditarFondoPension(int id, string nombre, decimal descuento)
        {
            InitializeComponent();
            // Asigna los valores recibidos a los controles del formulario
            IdFondoPension = id;
            txtNombreFPension.Text = nombre;
            txtDescuentoFPension.Text = descuento.ToString();
        }

        private void btnGuardarEditFPension_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            string nombre = txtNombreFPension.Text;
            string descuentoText = txtDescuentoFPension.Text;

            // Validar si el descuento está vacío
            if (string.IsNullOrWhiteSpace(descuentoText))
            {
                MessageBox.Show("Por favor, ingrese un valor para el descuento.");
            }
            else if (!decimal.TryParse(descuentoText, out decimal porcentajeDescuento))
            {
                MessageBox.Show("El valor ingresado para el descuento no es válido.");
            }
            else
            {
                // Llamar al método de la capa de negocio para editar el fondo de pensión
                try
                {
                    CN_FondoPension.EditarFondoPension(IdFondoPension, nombre, porcentajeDescuento);

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Fondo de pensión editado correctamente.");

                    // Cerrar el formulario después de guardar
                    this.Close();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar editar el fondo de pensión: " + ex.Message);
                }
            }
        }

        private void btnLimpiarFPension_Click(object sender, EventArgs e)
        {
            // Limpiar los campos del formulario
            txtNombreFPension.Text = "";
            txtDescuentoFPension.Text = "";
        }

        private void btnCancelarFPension_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
