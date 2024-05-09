using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
    public class CN_Bancos
    {
        public static List<Banco> ObtenerTodosBancos()
        {
            try
            {
                return CD_Bancos.ObtenerTodosBancos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener lista de bancos: " + ex.Message);
            }
        }
        public static void InsertarBanco(string nombre)
        {
            // Validar si el nombre está vacío
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");
            try
            {
                CD_Bancos.InsertarBanco(nombre);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el banco: " + ex.Message);
            }
        }
        public static void EditarBanco(int id, string nombre)
        {
            // Validar si el nombre está vacío
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");
            try
            {
                CD_Bancos.EditarBanco(id, nombre);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el banco: " + ex.Message);
            }
        }
        public static void EliminarBanco(int id)
        {
            try
            {
                CD_Bancos.EliminarBanco(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el banco: " + ex.Message);
            }
        }
        public static List<Banco> BuscarBanco (string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                throw new ArgumentException("Por favor, ingrese un nombre para buscar.");
            }
            try
            {
                return CD_Bancos.BuscarBanco(nombre);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar los bancos por nombre en la capa de negocio: " + ex.Message);
            }
        }
    }
}