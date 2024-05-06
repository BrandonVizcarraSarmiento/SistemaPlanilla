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
            var empleados = CN_Empleados.ObtenerTodosEmpleado();

            // Añadir columnas para las propiedades de Empleado
            dtgvEmpleado.Columns.Add("Id", "ID");
            dtgvEmpleado.Columns.Add("DNI", "DNI");
            dtgvEmpleado.Columns.Add("Nombres", "Nombres");
            dtgvEmpleado.Columns.Add("Apellidos", "Apellidos");
            dtgvEmpleado.Columns.Add("FechaInicioContrato", "Fecha Inicio Contrato");
            dtgvEmpleado.Columns.Add("FechaFinContrato", "Fecha Fin Contrato");
            dtgvEmpleado.Columns.Add("CuentaBancaria", "Cuenta Bancaria");

            // Añadir columnas para las propiedades de Banco, FondoPension y Cargo
            dtgvEmpleado.Columns.Add("NombreBanco", "Banco");
            dtgvEmpleado.Columns.Add("NombreFondoPension", "Fondo de Pension");
            dtgvEmpleado.Columns.Add("NombreCargo", "Cargo");

            // Llenar el DataGridView con los datos de los empleados
            foreach (var empleado in empleados)
            {
                dtgvEmpleado.Rows.Add(
                    empleado.Id,
                    empleado.DNI,
                    empleado.Nombres,
                    empleado.Apellidos,
                    empleado.FechaInicioContrato,
                    empleado.FechaFinContrato,
                    empleado.CuentaBancaria,
                    empleado.oBanco.Nombre,
                    empleado.oFondoPension.Nombre,
                    empleado.oCargo.Nombre
                );
            }
        }

    }
}
