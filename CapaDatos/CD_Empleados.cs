using CapaEntidad;
using System;
using System.Collections;
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
        public DataTable ObtenerEmpleados()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    string query = @"SELECT e.Id, e.DNI, e.Nombres, e.Apellidos, e.FechaInicioContrato, e.FechaFinContrato, e.CuentaBancaria,
                    b.Nombre AS NombreBanco, c.Nombre AS Cargo, fp.Nombre AS FondoPension
                    FROM Empleado e
                    INNER JOIN Banco b ON e.IdBanco = b.Id
                    INNER JOIN Cargo c ON e.IdCargo = c.Id
                    INNER JOIN FondoPension fp ON e.IdFondoPension = fp.Id";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        conexion.Open();
                        dt.Load(cmd.ExecuteReader());
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción mostrando un mensaje
                throw new Exception("Error al obtener los empleados: " + ex.Message);
            }

            return dt;
        }
        public void InsertarEmpleado(int dni, string nombres, string apellidos, DateTime fechaInicioContrato, DateTime fechaFinContrato, int cuentaBancaria, int idBanco, int idFondoPension, int idCargo)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                using (SqlCommand cmd = new SqlCommand("InsertarEmpleado", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DNI", dni);
                    cmd.Parameters.AddWithValue("@Nombres", nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", apellidos);
                    cmd.Parameters.AddWithValue("@FechaInicioContrato", fechaInicioContrato);
                    cmd.Parameters.AddWithValue("@FechaFinContrato", fechaFinContrato);
                    cmd.Parameters.AddWithValue("@CuentaBancaria", cuentaBancaria);
                    cmd.Parameters.AddWithValue("@IdBanco", idBanco);
                    cmd.Parameters.AddWithValue("@IdFondoPension", idFondoPension);
                    cmd.Parameters.AddWithValue("@IdCargo", idCargo);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EditarEmpleado(int id, int dni, string nombres, string apellidos, DateTime fechaInicioContrato, DateTime fechaFinContrato, int cuentaBancaria, int idBanco, int idFondoPension, int idCargo)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("EditarEmpleado", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@DNI", dni);
                        cmd.Parameters.AddWithValue("@Nombres", nombres);
                        cmd.Parameters.AddWithValue("@Apellidos", apellidos);
                        cmd.Parameters.AddWithValue("@FechaInicioContrato", fechaInicioContrato);
                        cmd.Parameters.AddWithValue("@FechaFinContrato", fechaFinContrato);
                        cmd.Parameters.AddWithValue("@CuentaBancaria", cuentaBancaria);
                        cmd.Parameters.AddWithValue("@IdBanco", idBanco);
                        cmd.Parameters.AddWithValue("@IdFondoPension", idFondoPension);
                        cmd.Parameters.AddWithValue("@IdCargo", idCargo);

                        conexion.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción mostrando un mensaje
                throw new Exception("Error al editar el empleado: " + ex.Message);
            }
        }
        public void EliminarEmpleado(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("EliminarEmpleado", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", id);

                        conexion.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción mostrando un mensaje
                throw new Exception("Error al eliminar el empleado: " + ex.Message);
            }
        }
        public DataTable BuscarEmpleado(string criterio, string busqueda)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("BuscarEmpleado", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DNI", (criterio == "DNI") ? Convert.ToInt32(busqueda) : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Nombres", (criterio == "Nombres") ? busqueda : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Apellidos", (criterio == "Apellidos") ? busqueda : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Cargo", (criterio == "Cargo") ? busqueda : (object)DBNull.Value);

                        conexion.Open();
                        dt.Load(cmd.ExecuteReader());
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción mostrando un mensaje
                throw new Exception("Error al buscar el empleado: " + ex.Message);
            }

            return dt;
        }

    }
}
