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
        public void InsertarEmpleado(string dnitext, string nombres, string apellidos, DateTime fechaInicioContrato, DateTime fechaFinContrato, string cuentaBancaria, int idBanco, int idFondoPension, int idCargo)
        {
            if (string.IsNullOrWhiteSpace(dnitext))
                throw new ArgumentException("El DNI no puede estar vacío.");
            // Intentar convertir el texto del DNI a un entero
            if (!int.TryParse(dnitext, out int dni))
                throw new ArgumentException("DNI debe ser numerico.");
            if (dnitext.Length != 8)
                throw new ArgumentException("El DNI debe tener exactamente 8 dígitos.");
            if (string.IsNullOrWhiteSpace(nombres))
                throw new ArgumentException("El nombre no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(apellidos))
                throw new ArgumentException("Los apellidos no pueden estar vacíos.");
            if (fechaInicioContrato == DateTime.MinValue)
                throw new ArgumentException("La fecha de inicio de contrato no puede estar vacía.");
            if (fechaFinContrato == DateTime.MinValue)
                throw new ArgumentException("La fecha de fin de contrato no puede estar vacía.");
            if (string.IsNullOrWhiteSpace(cuentaBancaria))
                throw new ArgumentException("La cuenta bancaria no puede estar vacía.");
            if (idBanco <= 0)
                throw new ArgumentException("Debe seleccionar un banco.");
            if (idFondoPension <= 0)
                throw new ArgumentException("Debe seleccionar un fondo de pensión.");
            if (idCargo <= 0)
                throw new ArgumentException("Debe seleccionar un cargo.");

            try
            {
                CD_Empleados cdEmpleados = new CD_Empleados();
                cdEmpleados.InsertarEmpleado(dni, nombres, apellidos, fechaInicioContrato, fechaFinContrato, cuentaBancaria, idBanco, idFondoPension, idCargo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar empleado en la capa de datos: " + ex.Message);
            }
        }
    }
}
