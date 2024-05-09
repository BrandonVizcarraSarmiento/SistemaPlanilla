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
using System.Windows.Documents;
using System.Windows.Forms;
namespace CapaPresentacion.Vistas_Banco
{
    public partial class FrmBanco : Form
    {
        public FrmBanco()
        {
            InitializeComponent();
        }
        private void FrmBanco_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            dtgvBanco.DataSource = CN_Bancos.ObtenerTodosBancos();
        }
        private void btnNuevoBanco_Click(object sender, EventArgs e)
        {
            // Abre el formulario para agregar fondo de pensión
            FrmAgregarBanco agregarForm = new FrmAgregarBanco();
            agregarForm.ShowDialog();

            // Recarga los datos después de agregar un nuevo fondo de pensión
            CargarDatos();
        }
        private void btnEditarBanco_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dtgvBanco.SelectedRows.Count > 0)
            {
                // Obtiene los datos de la fila seleccionada
                int id = Convert.ToInt32(dtgvBanco.SelectedRows[0].Cells["Id"].Value);
                string nombre = dtgvBanco.SelectedRows[0].Cells["Nombre"].Value.ToString();

                // Abre el formulario para editar fondo de pensión
                FrmEditarBanco editarForm = new FrmEditarBanco(id, nombre);
                editarForm.ShowDialog();

                // Recarga los datos después de editar el fondo de pensión
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Seleccione un registro para editar.");
            }
        }
        private void btnEliminarBanco_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dtgvBanco.SelectedRows.Count > 0)
            {
                // Pregunta al usuario si realmente desea eliminar el registro
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    // Obtiene el id del registro seleccionado
                    int id = Convert.ToInt32(dtgvBanco.SelectedRows[0].Cells["Id"].Value);

                    // Llama al método para eliminar el registro
                    CN_Bancos.EliminarBanco(id);

                    // Vuelve a cargar los datos en el DataGridView
                    CargarDatos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro para eliminar.");
            }
        }
        private void btnBuscarBanco_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtBuscarBanco.Text.Trim();

                // Llamar al método en la capa de negocio para buscar fondos de pensión por nombre
                List<Banco> listaBanco = CN_Bancos.BuscarBanco(nombre);

                if (listaBanco.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Mostrar los resultados en el DataGridView
                    dtgvBanco.DataSource = listaBanco;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar Bancos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}