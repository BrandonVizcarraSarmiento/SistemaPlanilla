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
    public class CD_Bancos
    {
        public List<Banco> Listar()
        {
            List<Banco> lista = new List<Banco>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.Id,u.Nombre,u.Correo,u.Clave,u.Estado,r.Id,r.Descripcion from Usuario u");
                    query.AppendLine("inner join Rol r on r.Id = u.IdRol");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Banco()
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nombre = reader["Nombre"].ToString(),
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Banco>();
                }
            }
            return lista;
        }
        public int Registrar(Banco banco, out string mensaje)
        {
            int idBancoGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARBANCO", conexion);
                    cmd.Parameters.AddWithValue("Nombre", banco.Nombre);
                    cmd.Parameters.Add("IdBancoResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    idBancoGenerado = Convert.ToInt32(cmd.Parameters["IdBancoResultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idBancoGenerado = 0;
                mensaje = ex.Message;
            }
            return idBancoGenerado;
        }

        // Método para editar un banco existente
        public bool Editar(Banco banco, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARBANCO", conexion);
                    cmd.Parameters.AddWithValue("Id", banco.Id);
                    cmd.Parameters.AddWithValue("Nombre", banco.Nombre);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }
            return respuesta;
        }

        // Método para eliminar un banco
        public bool Eliminar(int idBanco, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARBANCO", conexion);
                    cmd.Parameters.AddWithValue("Id", idBanco);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }
            return respuesta;
        }
    }
}