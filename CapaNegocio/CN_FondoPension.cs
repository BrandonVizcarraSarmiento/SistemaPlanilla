using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_FondoPension
    {
        // Método para obtener todos los fondos de pensión
        public static List<FondoPension> ObtenerTodosFondosPension()
        {
            try
            {
                // Llamar al método de la capa de datos para obtener todos los fondos de pensión
                return CD_FondoPension.ObtenerTodosFondosPension();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los fondos de pensión: " + ex.Message);
            }
        }
        // Método para insertar un fondo de pensión
        public static void InsertarFondoPension(string nombre, decimal porcentajeDescuento)
        {
            // Validar datos de entrada
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede estar vacío");

            if (porcentajeDescuento < 0 || porcentajeDescuento > 100)
                throw new ArgumentException("El porcentaje de descuento debe estar entre 0 y 100");
            try
            {
                // Llamar al método de la capa de datos para insertar
                CD_FondoPension.InsertarFondoPension(nombre, porcentajeDescuento);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar fondo de pensión: " + ex.Message);
            }
        }

        // Método para editar un fondo de pensión
        public static void EditarFondoPension(int id, string nombre, decimal porcentajeDescuento)
        {
            try
            {
                // Validar datos de entrada
                if (string.IsNullOrWhiteSpace(nombre))
                    throw new ArgumentException("El nombre no puede estar vacío");

                if (porcentajeDescuento < 0 || porcentajeDescuento > 100)
                    throw new ArgumentException("El porcentaje de descuento debe estar entre 0 y 100");

                // Llamar al método de la capa de datos para editar
                CD_FondoPension.EditarFondoPension(id, nombre, porcentajeDescuento);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar fondo de pensión: " + ex.Message);
            }
        }

        // Método para eliminar un fondo de pensión
        public static void EliminarFondoPension(int id)
        {
            try
            {
                // Llamar al método de la capa de datos para eliminar
                CD_FondoPension.EliminarFondoPension(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar fondo de pensión: " + ex.Message);
            }
        }
        // Método para buscar fondos de pensión por nombre
        public static List<FondoPension> BuscarFondoPension(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                throw new ArgumentException("Por favor, ingrese un nombre para buscar.");
            }
            try
            {
                // Llamar al método en la capa de datos para buscar fondos de pensión por nombre
                return CD_FondoPension.BuscarFondoPension(nombre);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar fondos de pensión por nombre en la capa de negocio: " + ex.Message);
            }
        }
    }
}
