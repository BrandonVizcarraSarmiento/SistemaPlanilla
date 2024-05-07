
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Vistas_Cargo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace CapaPresentacion.Vistas_Cargo
{
    public partial class FrmCargo : Form
    {
        public FrmCargo()
        {
            InitializeComponent();
        }

        private void FrmCargo_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dtgvCargo.DataSource = CN_Cargo.ObtenerTodosCargos();
        }

        private void btnNuevoCargo_Click(object sender, EventArgs e)
        {
            ///FrmAgregarCargo agregarForm = new FrmAgregarCargo();
            //agregarForm.ShowDialog();
            CargarDatos();
        }

        private void btnEditarCargo_Click(object sender, EventArgs e)
        {
            if (dtgvCargo.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dtgvCargo.SelectedRows[0].Cells["Id"].Value);
                string nombre = dtgvCargo.SelectedRows[0].Cells["Nombre"].Value.ToString();
                decimal sueldoMensual = Convert.ToDecimal(dtgvCargo.SelectedRows[0].Cells["SueldoMensual"].Value);

                //FrmEditarCargo editarForm = new FrmEditarCargo(id, nombre, sueldoMensual);
                //editarForm.ShowDialog();
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Seleccione un registro para editar.");
            }
        }

        private void btnEliminarCargo_Click(object sender, EventArgs e)
        {
            if (dtgvCargo.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dtgvCargo.SelectedRows[0].Cells["Id"].Value);
                    CN_Cargo.EliminarCargo(id);
                    CargarDatos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro para eliminar.");
            }
        }

        private void btnBuscarCargos_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtBuscarCargo.Text.Trim();
                List<Cargo> cargos = CN_Cargo.BuscarCargo(nombre);
                if (cargos.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MostrarCargos(cargos);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar cargos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarCargos(List<Cargo> cargos)
        {
            dtgvCargo.DataSource = cargos;
        }
    }
}
