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
using CapaEntidad;
using CapaPresentacion.Vistas_Empleados;

namespace CapaPresentacion.Vistas_Empleados
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            CN_Empleados cnEmpleados = new CN_Empleados();
            dtgvEmpleado.DataSource = cnEmpleados.MostrarEmpleados();
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FrmAgregarEmpleado agregarForm = new FrmAgregarEmpleado();
            agregarForm.ShowDialog();
            CargarDatos();
        }
    }
}
