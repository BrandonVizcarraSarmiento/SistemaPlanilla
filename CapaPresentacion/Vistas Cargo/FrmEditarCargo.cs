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




namespace CapaPresentacion.Vistas_Cargo
{
    public partial class FrmEditarCargo : Form
    {
        private int IdCargo;

        public FrmEditarCargo(int id, string nombre, decimal sueldoMensual)
        {
            InitializeComponent();
            IdCargo = id;
            txtNombreCargo.Text = nombre;
            txtSueldoMensual.Text = sueldoMensual.ToString();
        }

        private void btnGuardarEditCargo_Click_1(object sender, EventArgs e)
        {
            string nombre = txtNombreCargo.Text;
            string sueldoMensualText = txtSueldoMensual.Text;

            try
            {
                CN_Cargo.EditarCargo(IdCargo, nombre, sueldoMensualText);
                MessageBox.Show("Cargo editado correctamente.");
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar editar el cargo: " + ex.Message);
            }
        }

        private void btnLimpiarCargo_Click_1(object sender, EventArgs e)
        {
            txtNombreCargo.Text = "";
            txtSueldoMensual.Text = "";
        }

        private void btnCancelarCargo_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEditarCargo_Load_1(object sender, EventArgs e)
        {

        }
    }
}

