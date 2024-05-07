using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class CN_Cargo
    {
        public static List<Cargo> ObtenerTodosCargos()
        {
            try
            {
                return CD_Cargo.ObtenerTodosCargos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los cargos: " + ex.Message);
            }
        }

        public static void InsertarCargo(string nombre, string sueldoMensualText)
        {
            // Validar si el nombre está vacío
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");

            // Validar si el sueldo mensual está vacío
            if (string.IsNullOrWhiteSpace(sueldoMensualText))
                throw new ArgumentException("Por favor, ingrese un valor para el sueldo mensual.");

            // Intentar convertir el sueldo mensual a decimal
            if (!decimal.TryParse(sueldoMensualText, out decimal sueldoMensual))
                throw new ArgumentException("El valor ingresado para el sueldo mensual no es válido.");

            // Validar que el sueldo mensual sea mayor que cero
            if (sueldoMensual <= 0)
                throw new ArgumentException("El sueldo mensual debe ser mayor que cero.");

            try
            {
                CD_Cargo.InsertarCargo(nombre, sueldoMensual);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar cargo: " + ex.Message);
            }
        }

        public static void EditarCargo(int id, string nombre, string sueldoMensualText)
        {
            // Validar si el nombre está vacío
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");

            // Validar si el sueldo mensual está vacío
            if (string.IsNullOrWhiteSpace(sueldoMensualText))
                throw new ArgumentException("Por favor, ingrese un valor para el sueldo mensual.");

            // Intentar convertir el sueldo mensual a decimal
            if (!decimal.TryParse(sueldoMensualText, out decimal sueldoMensual))
                throw new ArgumentException("El valor ingresado para el sueldo mensual no es válido.");

            // Validar que el sueldo mensual sea mayor que cero
            if (sueldoMensual <= 0)
                throw new ArgumentException("El sueldo mensual debe ser mayor que cero.");

            try
            {
                CD_Cargo.EditarCargo(id, nombre, sueldoMensual);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar cargo: " + ex.Message);
            }
        }

        public static void EliminarCargo(int id)
        {
            try
            {
                CD_Cargo.EliminarCargo(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar cargo: " + ex.Message);
            }
        }

        public static List<Cargo> BuscarCargo(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                throw new ArgumentException("Por favor, ingrese un nombre para buscar.");
            }
            try
            {
                return CD_Cargo.BuscarCargo(nombre);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar cargos por nombre en la capa de negocio: " + ex.Message);
            }
        }
    }
}
