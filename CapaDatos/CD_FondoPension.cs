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
    public class CD_FondoPension
    {
        public static List<FondoPension> ObtenerTodosFondosPension()
        {
            List<FondoPension> listaFondosPension = new List<FondoPension>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM FondoPension", conexion);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        FondoPension fondoPension = new FondoPension();
                        fondoPension.Id = Convert.ToInt32(reader["Id"]);
                        fondoPension.Nombre = reader["Nombre"].ToString();
                        fondoPension.PorcentajeDescuento = Convert.ToDecimal(reader["PorcentajeDescuento"]);
                        listaFondosPension.Add(fondoPension);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los fondos de pensión: " + ex.Message);
            }
            return listaFondosPension;
        }
        // Método para insertar un fondo de pensión
        public static void InsertarFondoPension(string nombre, decimal porcentajeDescuento)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("InsertarFondoPension", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@PorcentajeDescuento", porcentajeDescuento);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar fondo de pensión: " + ex.Message);
            }
        }

        // Método para editar un fondo de pensión
        public static void EditarFondoPension(int id, string nombre, decimal porcentajeDescuento)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("EditarFondoPension", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@PorcentajeDescuento", porcentajeDescuento);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar fondo de pensión: " + ex.Message);
            }
        }
        // Método para eliminar un fondo de pensión
        public static void EliminarFondoPension(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("EliminarFondoPension", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar fondo de pensión: " + ex.Message);
            }
        }
        // Método para buscar fondos de pensión por nombre
        public static List<FondoPension> BuscarFondoPension(string nombre)
        {
            List<FondoPension> listaFondosPension = new List<FondoPension>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("BuscarFondoPension", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        FondoPension fondoPension = new FondoPension();
                        fondoPension.Id = Convert.ToInt32(reader["Id"]);
                        fondoPension.Nombre = reader["Nombre"].ToString();
                        fondoPension.PorcentajeDescuento = Convert.ToDecimal(reader["PorcentajeDescuento"]);
                        listaFondosPension.Add(fondoPension);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar fondos de pensión por nombre: " + ex.Message);
            }
            return listaFondosPension;
        }
    }
}
