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
    public class CD_Empleados
    {
        public static List<Empleado> ObtenerTodosEmpleado()
        {
            List<Empleado> listaEmpleado = new List<Empleado>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT E.Id, E.DNI, E.Nombres, E.Apellidos, E.FechaInicioContrato, E.FechaFinContrato, E.CuentaBancaria,");
                    query.AppendLine("B.Nombre AS NombreBanco, FP.Nombre AS NombreFondoPension, C.Nombre AS NombreCargo");
                    query.AppendLine("FROM Empleado E");
                    query.AppendLine("INNER JOIN Banco B ON E.IdBanco = B.Id");
                    query.AppendLine("INNER JOIN FondoPension FP ON E.IdFondoPension = FP.Id");
                    query.AppendLine("INNER JOIN Cargo C ON E.IdCargo = C.Id");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Empleado empleado = new Empleado()
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                DNI = Convert.ToInt32(reader["DNI"]),
                                Nombres = reader["Nombres"].ToString(),
                                Apellidos = reader["Apellidos"].ToString(),
                                FechaInicioContrato = Convert.ToDateTime(reader["FechaInicioContrato"]),
                                FechaFinContrato = Convert.ToDateTime(reader["FechaFinContrato"]),
                                CuentaBancaria = reader["CuentaBancaria"].ToString(),
                                oBanco = new Banco() { Nombre = reader["NombreBanco"].ToString() },
                                oFondoPension = new FondoPension() { Nombre = reader["NombreFondoPension"].ToString() },
                                oCargo = new Cargo() { Nombre = reader["NombreCargo"].ToString() }
                            };
                            listaEmpleado.Add(empleado);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener empleados: " + ex.Message);
                }
            }
            return listaEmpleado;
        }
    }
}
