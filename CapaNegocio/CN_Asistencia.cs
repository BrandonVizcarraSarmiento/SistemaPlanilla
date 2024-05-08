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
        public static List<Asistencia> ObtenerTodosAsistencia()
        {
            try
            {
                return CD_Asistencia.ObtenerTodosAsistencia();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener lista de bancos: " + ex.Message);
            }
        }
        public static void GuardarOActualizarAsistencia(Asistencia asistencia)
        {
           
        }
    }
}
