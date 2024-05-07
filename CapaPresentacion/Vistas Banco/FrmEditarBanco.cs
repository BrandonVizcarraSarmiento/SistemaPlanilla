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

namespace CapaPresentacion.Vistas_Banco
{
    public partial class FrmEditarBanco : Form
    {
        private int IdBanco;
        public FrmEditarBanco(int id, string nombre)
        {
            InitializeComponent();
            IdBanco = id;
            txtNombreBanco.Text = nombre;

        }

        private void btnGuardarEditBanco_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreBanco.Text;
            try
            {
                CN_Bancos.EditarBanco(IdBanco, nombre);
                MessageBox.Show("Banco editado correctamente.");
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar editar el Banco: " + ex.Message);
            }
        }

        private void btnLimpiarBanco_Click(object sender, EventArgs e)
        {
            txtNombreBanco.Text = "";
        }

        private void btnCancelarBanco_Click(object sender, EventArgs e)
        {
        this.Close();
        }
    }
}
