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

namespace CapaPresentacion.Vistas_Cargo
{
    public partial class FrmAgregarCargo : Form
    {
        public FrmAgregarCargo()
        {
            InitializeComponent();
        }
        private void LimpiarCampos()
        {
            txtNombreCargo.Text = "";
            txtSueldoMensual.Text = "";
        }

        private void FrmAgregarCargo_Load(object sender, EventArgs e)
        {
            // Puedes agregar código de inicialización aquí si es necesario
        }

        private void btnGuardarCargo_Click_1(object sender, EventArgs e)
        {
            string nombre = txtNombreCargo.Text;
            string sueldoMensualText = txtSueldoMensual.Text;

            try
            {
                CN_Cargo.InsertarCargo(nombre, sueldoMensualText);

                MessageBox.Show("Cargo agregado correctamente.");

                LimpiarCampos();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar guardar el cargo: " + ex.Message);
            }
        }

        private void btnLimpiarCargo_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCancelarCargo_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
