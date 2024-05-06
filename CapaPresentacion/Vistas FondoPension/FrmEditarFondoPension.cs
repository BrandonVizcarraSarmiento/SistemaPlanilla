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
            IdFondoPension = id;
            txtNombreFPension.Text = nombre;
            txtDescuentoFPension.Text = descuento.ToString();
        }

        private void btnGuardarEditFPension_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreFPension.Text;
            string descuentoText = txtDescuentoFPension.Text;

            try
            {
                CN_FondoPension.EditarFondoPension(IdFondoPension, nombre, descuentoText);
                MessageBox.Show("Fondo de pensión editado correctamente.");
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

        private void btnLimpiarFPension_Click(object sender, EventArgs e)
        {
            txtNombreFPension.Text = "";
            txtDescuentoFPension.Text = "";
        }

        private void btnCancelarFPension_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
