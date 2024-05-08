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
        public static List<Asistencia> ObtenerTodosAsistencia()
        {
            List<Asistencia> listaAsistencia = new List<Asistencia>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Asistencia", conexion);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Asistencia asistencia = new Asistencia();
                        asistencia.Id = Convert.ToInt32(reader["Id"]);
                        asistencia.Mes = Convert.ToInt32(reader["Mes"]);
                        asistencia.Ano = Convert.ToInt32(reader["Ano"]);
                        asistencia.DiasLaborados = Convert.ToInt32(reader["DiasLaborados"]);
                        asistencia.DiasNoLaborados = Convert.ToInt32(reader["DiasNoLaborados"]);
                        asistencia.DiasEfectivos = Convert.ToInt32(reader["DiasEfectivos"]);
                        asistencia.oEmpleado = new Empleado();
                        listaAsistencia.Add(asistencia);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener lista de bancos: " + ex.Message);
            }
            return listaAsistencia;
        }
    }
}