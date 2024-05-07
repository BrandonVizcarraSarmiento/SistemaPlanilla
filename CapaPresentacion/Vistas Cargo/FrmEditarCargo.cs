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

        private void btnGuardarEditCargo_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txtNombreCargo.Text;
            string nuevoSueldoMensual = txtSueldoMensual.Text;

            try
            {
                CN_Cargo.EditarCargo(IdCargo, nuevoNombre, nuevoSueldoMensual);
                MessageBox.Show("Cargo editado correctamente.");
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar editar el cargo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarCargo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCancelarCargo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtNombreCargo.Text = "";
            txtSueldoMensual.Text = "";
        }
    }
}
