using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Conceptos
    {
        public static List<Concepto> ObtenerTodosConceptos()
        {
            try
            {
                return CD_Concepto.ObtenerTodosConceptos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los conceptos: " + ex.Message);
            }
        }

        public static void InsertarConcepto(string codigo, string nombre, string tipo)
        {
            // Validar si el código está vacío
            if (string.IsNullOrWhiteSpace(codigo))
                throw new ArgumentException("El código no puede estar vacío.");

            // Validar si el nombre está vacío
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");

            // Validar si el tipo está vacío
            if (string.IsNullOrWhiteSpace(tipo))
                throw new ArgumentException("El tipo no puede estar vacío.");

            try
            {
                CD_Concepto.InsertarConcepto(codigo, nombre, tipo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar concepto: " + ex.Message);
            }
        }

        public static void EditarConcepto(int id, string codigo, string nombre, string tipo)
        {
            // Validar si el código está vacío
            if (string.IsNullOrWhiteSpace(codigo))
                throw new ArgumentException("El código no puede estar vacío.");

            // Validar si el nombre está vacío
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");

            // Validar si el tipo está vacío
            if (string.IsNullOrWhiteSpace(tipo))
                throw new ArgumentException("El tipo no puede estar vacío.");

            try
            {
                CD_Concepto.EditarConcepto(id, codigo, nombre, tipo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar concepto: " + ex.Message);
            }
        }

        public static void EliminarConcepto(int id)
        {
            try
            {
                CD_Concepto.EliminarConcepto(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar concepto: " + ex.Message);
            }
        }

        public static List<Concepto> BuscarConcepto(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                throw new ArgumentException("Por favor, ingrese un nombre para buscar.");
            }
            try
            {
                return CD_Concepto.BuscarConcepto(nombre);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar conceptos por nombre en la capa de negocio: " + ex.Message);
            }
        }
    }
}
