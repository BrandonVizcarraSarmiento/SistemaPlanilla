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
        // Método para cargar los datos en el DataGridView
        private void CargarDatos()
        {
            dtgvFPension.DataSource = CN_FondoPension.ObtenerTodosFondosPension();
        }

        private void btnNuevoFPension_Click(object sender, EventArgs e)
        {
            // Abre el formulario para agregar fondo de pensión
            FrmAgregarFondoPension agregarForm = new FrmAgregarFondoPension();
            agregarForm.ShowDialog();

            // Recarga los datos después de agregar un nuevo fondo de pensión
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

               // Abre el formulario para editar fondo de pensión
               FrmEditarFondoPension editarForm = new FrmEditarFondoPension(id, nombre, porcentajeDescuento);
               editarForm.ShowDialog();

               // Recarga los datos después de editar el fondo de pensión
               CargarDatos();
            }
            else
            {
               MessageBox.Show("Seleccione un registro para editar.");
            }
        }

        private void btnEliminarFPension_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dtgvFPension.SelectedRows.Count > 0)
            {
                // Pregunta al usuario si realmente desea eliminar el registro
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    // Obtiene el id del registro seleccionado
                    int id = Convert.ToInt32(dtgvFPension.SelectedRows[0].Cells["Id"].Value);

                    // Llama al método para eliminar el registro
                    CN_FondoPension.EliminarFondoPension(id);

                    // Vuelve a cargar los datos en el DataGridView
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

                // Llamar al método en la capa de negocio para buscar fondos de pensión por nombre
                List<FondoPension> fondosPension = CN_FondoPension.BuscarFondoPension(nombre);

                if (fondosPension.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Mostrar los resultados en el DataGridView
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
        // Método para mostrar los fondos de pensión en el DataGridView
        private void MostrarFondosPension(List<FondoPension> fondosPension)
        {
            dtgvFPension.DataSource = fondosPension;
        }
    }
}
