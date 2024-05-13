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
        public static DataTable ObtenerDatosPlanilla()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.cadena))
                {
                    string query = @"
                        SELECT 
                            CONCAT(e.Nombres, ' ', e.Apellidos) AS NombreCompleto,
                            e.DNI,
                            c.Nombre AS Cargo,
                            CAST(c.SueldoMensual AS DECIMAL(10, 2)) AS IngresoMes,
                            CASE
                                WHEN fp.Nombre = 'AFP' THEN CAST((c.SueldoMensual * fp.PorcentajeDescuento) AS DECIMAL(10, 2))
                                WHEN fp.Nombre = 'ONP' THEN CAST((c.SueldoMensual * fp.PorcentajeDescuento) AS DECIMAL(10, 2))
                            END AS DescuentoAFPONP,
                            CAST((c.SueldoMensual * a.DiasNoLaborados * 30 / c.SueldoMensual) AS DECIMAL(10, 2)) AS DiasNoLaborados,
                            CAST((c.SueldoMensual * 0.09) AS DECIMAL(10, 2)) AS Essalud,
                            CAST(((c.SueldoMensual * a.DiasLaborados) - (c.SueldoMensual * fp.PorcentajeDescuento) - (c.SueldoMensual * a.DiasNoLaborados * 30 / c.SueldoMensual) - (c.SueldoMensual * 0.09)) AS DECIMAL(10, 2)) AS TotalNeto
                        FROM 
                            Empleado e
                        INNER JOIN 
                            Cargo c ON e.IdCargo = c.Id
                        INNER JOIN 
                            Asistencia a ON e.Id = a.IdEmpleado
                        INNER JOIN 
                            FondoPension fp ON e.IdFondoPension = fp.Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            connection.Open();
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar excepción, puedes lanzarla nuevamente o registrarla en un archivo de registro
                throw ex;
            }

            return dataTable;
        }
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
