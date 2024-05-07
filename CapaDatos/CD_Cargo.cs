using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Cargo
    {
        public static List<Cargo> ObtenerTodosCargos()
        {
            List<Cargo> listaCargos = new List<Cargo>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Cargo", conexion);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Cargo cargo = new Cargo();
                        cargo.Id = Convert.ToInt32(reader["Id"]);
                        cargo.Nombre = reader["Nombre"].ToString();
                        cargo.SueldoMensual = Convert.ToDecimal(reader["SueldoMensual"]);
                        listaCargos.Add(cargo);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los cargos: " + ex.Message);
            }
            return listaCargos;
        }

        public static void InsertarCargo(string nombre, decimal sueldoMensual)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("InsertarCargo", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@SueldoMensual", sueldoMensual);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar cargo: " + ex.Message);
            }
        }

        public static void EditarCargo(int id, string nombre, decimal sueldoMensual)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("EditarCargo", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@SueldoMensual", sueldoMensual);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar cargo: " + ex.Message);
            }
        }

        public static void EliminarCargo(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("EliminarCargo", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar cargo: " + ex.Message);
            }
        }

        public static List<Cargo> BuscarCargo(string nombre)
        {
            List<Cargo> listaCargos = new List<Cargo>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("BuscarCargo", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Cargo cargo = new Cargo();
                        cargo.Id = Convert.ToInt32(reader["Id"]);
                        cargo.Nombre = reader["Nombre"].ToString();
                        cargo.SueldoMensual = Convert.ToDecimal(reader["SueldoMensual"]);
                        listaCargos.Add(cargo);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar cargos por nombre: " + ex.Message);
            }
            return listaCargos;
        }
    }
}
