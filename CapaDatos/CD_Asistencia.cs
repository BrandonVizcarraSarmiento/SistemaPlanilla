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
        public DataTable ObtenerDatosAsistenciaPorMesYAño(int mes, int año)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                string consulta = "SELECT * FROM Asistencia WHERE Mes = @Mes AND Ano = @Ano";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Mes", mes);
                comando.Parameters.AddWithValue("@Ano", año);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(dt);
            }

            return dt;
        }

        public void GuardarOActualizarAsistencia(Asistencia asistencia)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                string consulta = "INSERT INTO Asistencia (Mes, Ano, DiasLaborados, DiasNoLaborados, DiasEfectivos) " +
                                  "VALUES (@Mes, @Ano, @DiasLaborados, @DiasNoLaborados, @DiasEfectivos)";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Mes", asistencia.Mes);
                comando.Parameters.AddWithValue("@Ano", asistencia.Ano);
                comando.Parameters.AddWithValue("@DiasLaborados", asistencia.DiasLaborados);
                comando.Parameters.AddWithValue("@DiasNoLaborados", asistencia.DiasNoLaborados);
                comando.Parameters.AddWithValue("@DiasEfectivos", asistencia.DiasEfectivos);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }
    }
}