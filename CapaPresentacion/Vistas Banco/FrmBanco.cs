using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace CapaPresentacion.Vistas_Banco
{
    public partial class FrmBanco : Form
    {
        private CN_Bancos cnBancos;
        private Banco bancoSeleccionado;
        public FrmBanco()
        {
            InitializeComponent();
            cnBancos = new CN_Bancos();
            bancoSeleccionado = null;
        }
        private void FormBancos_Load(object sender, EventArgs e)
        {
            CargarBancos();
        }

        private void CargarBancos()
        {
            dtgvBanco.DataSource = cnBancos.Listar();
        }

        private void LimpiarCampos()
        {
            btnEliminarBanco.Text = "";
            bancoSeleccionado = null;
        }

        private void dtgvBanco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        if (e.RowIndex >= 0 && e.ColumnIndex == dtgvBanco.Columns["btnseleccionar"].Index)
        {
           int indice = e.RowIndex;

            txtIn.Text = indice.ToString();
            txtId.Text = dtgvBanco.Rows[indice].Cells["Id"].Value.ToString();
            txtNombre.Text = dtgvBanco.Rows[indice].Cells["Nombre"].Value.ToString();

            if (dtgvBanco.SelectedRows.Count > 0)
            {
                bancoSeleccionado = dtgvBanco.SelectedRows[0].DataBoundItem as Banco;

                if (bancoSeleccionado != null)
                {
                    dtgvBanco.Text = bancoSeleccionado.Nombre;
                }
            }
        }
    }

        private void btnNuevoBanco_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            Banco nuevoBanco = new Banco()
            {
                Nombre = btnNuevoBanco.Text.Trim()
            };

            int idBancoGenerado = cnBancos.Registrar(nuevoBanco, out mensaje);

            if (idBancoGenerado > 0)
            {
                MessageBox.Show("Banco registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarBancos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al registrar banco: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarBanco_Click(object sender, EventArgs e)
        {
            if (bancoSeleccionado != null)
            {
                string mensaje = "";
                bancoSeleccionado.Nombre = btnEditarBanco.Text.Trim();

                bool exito = cnBancos.Editar(bancoSeleccionado, out mensaje);

                if (exito)
                {
                    MessageBox.Show("Banco actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarBancos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al editar banco: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un banco de la lista para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarBanco_Click(object sender, EventArgs e)
        {
            
        }
    }
}