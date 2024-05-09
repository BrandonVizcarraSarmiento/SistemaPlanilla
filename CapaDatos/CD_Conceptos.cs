using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Concepto
    {
        public static List<Concepto> ObtenerTodosConceptos()
        {
            List<Concepto> listaConceptos = new List<Concepto>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Concepto", conexion);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Concepto concepto = new Concepto();
                        concepto.Id = Convert.ToInt32(reader["Id"]);
                        concepto.Codigo = reader["Codigo"].ToString();
                        concepto.Nombre = reader["Nombre"].ToString();
                        concepto.Tipo = reader["Tipo"].ToString();
                        listaConceptos.Add(concepto);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los conceptos: " + ex.Message);
            }
            return listaConceptos;
        }

        public static void InsertarConcepto(string codigo, string nombre, string tipo)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("InsertarConcepto", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar concepto: " + ex.Message);
            }
        }

        public static void EditarConcepto(int id, string codigo, string nombre, string tipo)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("EditarConcepto", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar concepto: " + ex.Message);
            }
        }

        public static void EliminarConcepto(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("EliminarConcepto", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar concepto: " + ex.Message);
            }
        }

        public static List<Concepto> BuscarConcepto(string nombre)
        {
            List<Concepto> listaConceptos = new List<Concepto>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("BuscarConcepto", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Concepto concepto = new Concepto();
                        concepto.Id = Convert.ToInt32(reader["Id"]);
                        concepto.Codigo = reader["Codigo"].ToString();
                        concepto.Nombre = reader["Nombre"].ToString();
                        concepto.Tipo = reader["Tipo"].ToString();
                        listaConceptos.Add(concepto);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar conceptos por nombre: " + ex.Message);
            }
            return listaConceptos;
        }
    }
}
