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
    }
}