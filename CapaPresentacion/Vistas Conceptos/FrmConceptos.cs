using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion.Vistas_Conceptos
{
    public partial class FrmConceptos : Form
    {
        public FrmConceptos()
        {
            InitializeComponent();
        }


        private void CargarDatos()
        {
            dtgvConceptos.DataSource = CN_Conceptos.ObtenerTodosConceptos();
        }

        private void btnNuevosConceptos_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para agregar un nuevo concepto
            FrmAgregarConceptos agregarConceptoForm = new FrmAgregarConceptos();
            agregarConceptoForm.ShowDialog();
            CargarDatos(); // Actualizar los datos en el DataGridView
        }

        private void btnEditarConceptos_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un concepto en el DataGridView
            if (dtgvConceptos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dtgvConceptos.SelectedRows[0].Cells["Id"].Value);
                string codigo = dtgvConceptos.SelectedRows[0].Cells["Codigo"].Value.ToString();
                string nombre = dtgvConceptos.SelectedRows[0].Cells["Nombre"].Value.ToString();
                string tipo = dtgvConceptos.SelectedRows[0].Cells["Tipo"].Value.ToString();

                // Abrir el formulario para editar el concepto seleccionado
                FrmEditarConceptos editarConceptoForm = new FrmEditarConceptos(id, codigo, nombre, tipo);
                editarConceptoForm.ShowDialog();
                CargarDatos(); // Actualizar los datos en el DataGridView
            }
            else
            {
                MessageBox.Show("Seleccione un concepto para editar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarConceptos_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un concepto en el DataGridView
            if (dtgvConceptos.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este concepto?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dtgvConceptos.SelectedRows[0].Cells["Id"].Value);

                    // Eliminar el concepto seleccionado
                    CN_Conceptos.EliminarConcepto(id);
                    CargarDatos(); // Actualizar los datos en el DataGridView
                }
            }
            else
            {
                MessageBox.Show("Seleccione un concepto para eliminar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscarConceptos_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtBuscarConceptos.Text.Trim();

                // Buscar conceptos por nombre
                List<Concepto> conceptos = CN_Conceptos.BuscarConcepto(nombre);

                // Asignar los resultados al DataGridView
                dtgvConceptos.DataSource = conceptos;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar conceptos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmConceptos_Load_1(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
