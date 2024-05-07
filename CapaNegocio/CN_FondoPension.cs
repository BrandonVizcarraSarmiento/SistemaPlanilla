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
    public class CN_FondoPension
    {
        public static List<FondoPension> ObtenerTodosFondosPension()
        {
            try
            {
                return CD_FondoPension.ObtenerTodosFondosPension();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los fondos de pensión: " + ex.Message);
            }
        }
        public static void InsertarFondoPension(string nombre, string descuentoText)
        {
            // Validar si el nombre está vacío
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");

            // Validar si el descuento está vacío
            if (string.IsNullOrWhiteSpace(descuentoText))
                throw new ArgumentException("Por favor, ingrese un valor para el descuento.");

            // Intentar convertir el descuento a decimal
            if (!decimal.TryParse(descuentoText, out decimal porcentajeDescuento))
                throw new ArgumentException("El valor ingresado para el descuento no es válido.");

            // Validar el rango del descuento
            if (porcentajeDescuento < 0 || porcentajeDescuento > 100)
                throw new ArgumentException("El porcentaje de descuento debe estar entre 0 y 100.");

            try
            {
                CD_FondoPension.InsertarFondoPension(nombre, porcentajeDescuento);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar fondo de pensión: " + ex.Message);
            }
        }

        public static void EditarFondoPension(int id, string nombre, string descuentoText)
        {
            // Validar si el nombre está vacío
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");

            // Validar si el descuento está vacío
            if (string.IsNullOrWhiteSpace(descuentoText))
                throw new ArgumentException("Por favor, ingrese un valor para el descuento.");

            // Intentar convertir el descuento a decimal
            if (!decimal.TryParse(descuentoText, out decimal porcentajeDescuento))
                throw new ArgumentException("El valor ingresado para el descuento no es válido.");

            // Validar el rango del descuento
            if (porcentajeDescuento < 0 || porcentajeDescuento > 100)
                throw new ArgumentException("El porcentaje de descuento debe estar entre 0 y 100.");

            try
            {
                CD_FondoPension.EditarFondoPension(id, nombre, porcentajeDescuento);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar fondo de pensión: " + ex.Message);
            }
        }

        public static void EliminarFondoPension(int id)
        {
            try
            {
                CD_FondoPension.EliminarFondoPension(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar fondo de pensión: " + ex.Message);
            }
        }
        public static List<FondoPension> BuscarFondoPension(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                throw new ArgumentException("Por favor, ingrese un nombre para buscar.");
            }
            try
            {
                return CD_FondoPension.BuscarFondoPension(nombre);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar fondos de pensión por nombre en la capa de negocio: " + ex.Message);
            }
        }
    }
}
