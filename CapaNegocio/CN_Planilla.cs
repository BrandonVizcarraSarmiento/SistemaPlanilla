using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Planilla
    {
        public DataTable ObtenerSalariosNetos(int mes, int ano)
        {
            try
            {
                CD_Planilla consultasSQL = new CD_Planilla();
                return consultasSQL.ObtenerSalariosNetos(mes, ano);
            }
            catch (Exception ex)
            {
                // Manejar la excepción, puedes lanzarla nuevamente o registrarla en un archivo de registro
                throw ex;
            }
        }
        public DataTable ObtenerDatosPlanilla()
        {
            try
            {
                // Llamar al método estático de la capa de datos para obtener todos los datos de la planilla
                return CD_Planilla.ObtenerDatosPlanilla();
            }
            catch (Exception ex)
            {
                // Manejar la excepción, puedes lanzarla nuevamente o registrarla en un archivo de registro
                throw ex;
            }
        }
    }
}
