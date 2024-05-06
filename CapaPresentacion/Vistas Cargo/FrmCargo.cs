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

namespace CapaPresentacion.Cargo
{
    public partial class FrmCargo : Form
    {
        // Cadena de conexión a la base de datos
        private string connectionString = "Data Source=LAPTOP-HS44347Q\\SQLEXPRESS;Initial Catalog=DBplanilla;Integrated Security=True";

        public FrmCargo()
        {
            InitializeComponent();
        }

        private void FrmCargo_Load(object sender, EventArgs e)
        {
            CargarDatosDesdeBD();
        }

        private void CargarDatosDesdeBD()
        {
            // Crear una conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Query SQL para seleccionar los datos de la tabla Cargo
                string query = "SELECT Id, Nombre, SueldoMensual FROM Cargo";

                // Crear un SqlDataAdapter para ejecutar la consulta y llenar un DataTable
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    // Crear un DataTable para almacenar los resultados de la consulta
                    DataTable dataTable = new DataTable();

                    // Abrir la conexión y llenar el DataTable con los datos de la consulta
                    connection.Open();
                    adapter.Fill(dataTable);

                    // Asignar el DataTable como origen de datos del DataGridView
                    dtgvCargo.DataSource = dataTable;
                }
            }
        }

        private void dtgvCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Manejar el evento CellContentClick aquí si es necesario
            // Por ejemplo, puedes obtener el valor de la celda seleccionada:
            // var valor = dtgvCargo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void btnNuevoCargo_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario FrmCargoNUEVOEDITAR
            FrmCargoNuevo frmCargoNuevoEditar = new FrmCargoNuevo();

            // Mostrar el formulario FrmCargoNUEVOEDITAR
            frmCargoNuevoEditar.ShowDialog();
        }

        private void btnEditarCargo_Click(object sender, EventArgs e)
        {

        }
    }
}