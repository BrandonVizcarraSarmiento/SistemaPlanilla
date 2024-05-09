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
    public partial class FrmFondoPension : Form
    {
        public FrmFondoPension()
        {
            InitializeComponent();
        }

        private void FrmFondoPension_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            dtgvFPension.DataSource = CN_FondoPension.ObtenerTodosFondosPension();
        }

        private void btnNuevoFPension_Click(object sender, EventArgs e)
        {
            FrmAgregarFondoPension agregarForm = new FrmAgregarFondoPension();
            agregarForm.ShowDialog();

            CargarDatos();
        }

        private void btnEditarFPension_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dtgvFPension.SelectedRows.Count > 0)
            {
               // Obtiene los datos de la fila seleccionada
               int id = Convert.ToInt32(dtgvFPension.SelectedRows[0].Cells["Id"].Value);
               string nombre = dtgvFPension.SelectedRows[0].Cells["Nombre"].Value.ToString();
               decimal porcentajeDescuento = Convert.ToDecimal(dtgvFPension.SelectedRows[0].Cells["PorcentajeDescuento"].Value);

               FrmEditarFondoPension editarForm = new FrmEditarFondoPension(id, nombre, porcentajeDescuento);
               editarForm.ShowDialog();

               CargarDatos();
            }
            else
            {
               MessageBox.Show("Seleccione un registro para editar.");
            }
        }

        private void btnEliminarFPension_Click(object sender, EventArgs e)
        {
            if (dtgvFPension.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dtgvFPension.SelectedRows[0].Cells["Id"].Value);

                    CN_FondoPension.EliminarFondoPension(id);

                    CargarDatos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro para eliminar.");
            }
        }

        private void btnBuscarFPension_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtBuscarFPension.Text.Trim();

                List<FondoPension> fondosPension = CN_FondoPension.BuscarFondoPension(nombre);

                if (fondosPension.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dtgvFPension.DataSource = fondosPension;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar fondos de pensión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
