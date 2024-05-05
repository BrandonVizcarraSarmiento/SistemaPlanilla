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
            try
            {
                // Obtener los datos del formulario
                string nombre = txtNombreFPension.Text;
                decimal descuento = decimal.Parse(txtDescuentoFPension.Text);

                // Llamar al método de la capa de negocio para editar el fondo de pensión
                CN_FondoPension.EditarFondoPension(IdFondoPension, nombre, descuento);

                // Mostrar mensaje de éxito
                MessageBox.Show("Fondo de pensión editado correctamente.");

                // Cerrar el formulario después de guardar
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar fondo de pensión: " + ex.Message);
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
