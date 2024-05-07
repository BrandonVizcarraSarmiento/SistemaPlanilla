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
    }
}