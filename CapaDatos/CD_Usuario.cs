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
    public class CD_Usuario
    {
        public DataTable ObtenerUsuariosConRoles()
        {
            DataTable resultados = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string consulta = @"
                        SELECT 
                            u.Id,
                            u.Nombre,
                            u.Correo,
                            u.Clave,
                            u.Estado,
                            r.Id AS IdRol,
                            r.Descripcion
                        FROM 
                            Usuario u
                        INNER JOIN 
                            Rol r ON r.Id = u.IdRol";

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
                throw new Exception("Error al obtener los usuarios: " + ex.Message);
            }
            return resultados;
        }
        public DataTable ObtenerUsuarioPorCorreoYClave(string correo, string clave)
        {
            DataTable resultados = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string consulta = @"
                    SELECT 
                        Id,
                        Nombre,
                        Correo,
                        Clave
                    FROM 
                        Usuario
                    WHERE 
                        Correo = @Correo AND Clave = @Clave";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Correo", correo);
                        comando.Parameters.AddWithValue("@Clave", clave);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                        {
                            adapter.Fill(resultados);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los usuarios: " + ex.Message);
            }
            return resultados;
        }
        public void AgregarUsuario(string nombre, string correo, string clave, int idRol, bool estado)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("AgregarUsuario", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Correo", correo);
                        comando.Parameters.AddWithValue("@Clave", clave);
                        comando.Parameters.AddWithValue("@IdRol", idRol);
                        comando.Parameters.AddWithValue("@Estado", estado);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el usuario: " + ex.Message);
            }
        }
        public void EditarUsuario(int id, string nombre, string correo, string clave, int idRol, bool estado)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("EditarUsuario", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Id", id);
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Correo", correo);
                        comando.Parameters.AddWithValue("@Clave", clave);
                        comando.Parameters.AddWithValue("@IdRol", idRol);
                        comando.Parameters.AddWithValue("@Estado", estado);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el usuario: " + ex.Message);
            }
        }
        public void EliminarUsuario(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.cadena))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("EliminarUsuario", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el usuario: " + ex.Message);
            }
        }
        public DataTable BuscarUsuario(string nombre, string correo)
        {
            DataTable resultados = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("BuscarUsuario", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Nombre", nombre ?? (object)DBNull.Value);
                        comando.Parameters.AddWithValue("@Correo", correo ?? (object)DBNull.Value);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                        {
                            adapter.Fill(resultados);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar usuarios: " + ex.Message);
            }
            return resultados;
        }
    }
}
