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
        public DataTable ObtenerRoles()
        {
            DataTable resultados = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string consulta = "SELECT Id, Descripcion FROM Rol";

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
                throw new Exception("Error al obtener los roles: " + ex.Message);
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
    }
}
