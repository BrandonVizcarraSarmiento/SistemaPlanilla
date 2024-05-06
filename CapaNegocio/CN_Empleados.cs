using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Empleados
    {
        public static List<Empleado> ObtenerTodosEmpleado()
        {
            try
            {
                return CD_Empleados.ObtenerTodosEmpleado();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los empleados: " + ex.Message);
            }
        }
    }
}
