using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Empleados
    {
        public DataTable MostrarEmpleados()
        {
            CD_Empleados cdEmpleados = new CD_Empleados();
            return cdEmpleados.ObtenerEmpleados();
        }
        public void InsertarEmpleado(int dni, string nombres, string apellidos, DateTime fechaInicioContrato, DateTime fechaFinContrato, string cuentaBancaria, int idBanco, int idFondoPension, int idCargo)
        {
            CD_Empleados cdEmpleados = new CD_Empleados();
            cdEmpleados.InsertarEmpleado(dni, nombres, apellidos, fechaInicioContrato, fechaFinContrato, cuentaBancaria, idBanco, idFondoPension, idCargo);
        }
    }
}
