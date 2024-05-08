using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Planilla
    {
        public DataTable ObtenerSalariosNetos(int mes, int ano)
        {
            DataTable resultados = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.cadena))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("ObtenerPlanillaPorMesYAno", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MesParametro", mes);
                        command.Parameters.AddWithValue("@AnoParametro", ano);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(resultados);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar excepción, puedes lanzarla nuevamente o registrarla en un archivo de registro
                throw ex;
            }

            return resultados;
        }
    }
}
