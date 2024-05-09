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
    public class CD_Bancos
    {
        public static List<Banco> ObtenerTodosBancos()
        {
            List<Banco> listaBanco = new List<Banco>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Banco", conexion);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Banco banco = new Banco();
                        banco.Id = Convert.ToInt32(reader["Id"]);
                        banco.Nombre = reader["Nombre"].ToString();
                        listaBanco.Add(banco);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener lista de bancos: " + ex.Message);
            }
            return listaBanco;
        }
        public static void InsertarBanco(string nombre)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("InsertarBanco", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar banco: " + ex.Message);
            }
        }
        public static void EditarBanco(int id, string nombre)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("EditarBanco", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el Banco: " + ex.Message);
            }
        }
        public static void EliminarBanco(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("EliminarBanco", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el Banco: " + ex.Message);
            }
        }
        public static List<Banco> BuscarBanco(string nombre)
        {
            List<Banco> listaBanco = new List<Banco>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("BuscarBanco", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Banco banco = new Banco();
                        banco.Id = Convert.ToInt32(reader["Id"]);
                        banco.Nombre = reader["Nombre"].ToString();
                        listaBanco.Add(banco);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el Banco por nombre: " + ex.Message);
            }
            return listaBanco;
        }
    }
}