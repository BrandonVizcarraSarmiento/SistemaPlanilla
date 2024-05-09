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

namespace CapaPresentacion.Vistas_Banco
{
    public partial class FrmAgregarBanco : Form
    {
        public FrmAgregarBanco()
        {
            InitializeComponent();
        }

        private void btnGuardarBanco_Click(object sender, EventArgs e)
        {

            string nombre = txtNombreBanco.Text;

            try
            {
                CN_Bancos.InsertarBanco(nombre);

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
            txtNombreBanco.Text = "";
        }

        private void btnLimpiarBanco_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCancelarBanco_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
