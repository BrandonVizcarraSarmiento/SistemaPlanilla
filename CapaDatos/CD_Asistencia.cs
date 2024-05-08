using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Asistencia
    {
        public DataTable ObtenerDatosAsistencia()
        {
            DataTable resultados = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string consulta = @"
                        SELECT 
                            CONCAT(e.Nombres, ' ', e.Apellidos) AS NombreCompleto,
                            e.DNI,
                            c.Nombre AS Cargo,
                            a.DiasLaborados,
                            a.DiasNoLaborados,
                            a.DiasEfectivos
                        FROM 
                            Empleado e
                        JOIN 
                            Asistencia a ON e.Id = a.IdEmpleado
                        JOIN 
                            Cargo c ON e.IdCargo = c.Id";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                        {
                            adapter.Fill(resultados);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones (por ejemplo, registrar o lanzar)
                throw ex;
            }
            return resultados;
        }
    }
}