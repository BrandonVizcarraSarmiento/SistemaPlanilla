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
           
        }
    }
}
