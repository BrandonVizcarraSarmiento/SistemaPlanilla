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
    public class CN_Asistencia
    {
        public DataTable ObtenerDatosAsistencia()
        {
            DataTable resultados = new DataTable();
            try
            {
                CD_Asistencia cdAsistencia = new CD_Asistencia();
                resultados = cdAsistencia.ObtenerDatosAsistencia();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultados;
        }
        public static void GuardarOActualizarAsistencia(Asistencia asistencia)
        {
            try
            {
                // Llamar al método en la capa de datos para guardar o actualizar la asistencia
                CD_Asistencia cdAsistencia = new CD_Asistencia();
                cdAsistencia.GuardarOActualizarAsistencia(asistencia);
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción y relanzarla
                throw new Exception("Error al guardar o actualizar la asistencia.", ex);
            }
        }
        public DataTable ObtenerDatosAsistenciaPorMesYAño(int mes, int año)
        {
            try
            {
                // Llamar al método en la capa de datos para obtener los datos filtrados por mes y año
                CD_Asistencia cdAsistencia = new CD_Asistencia();
                return cdAsistencia.ObtenerDatosAsistenciaPorMesYAño(mes, año);
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción y relanzarla
                throw new Exception("Error al obtener los datos de asistencia por mes y año.", ex);
            }
        }
    }
}
