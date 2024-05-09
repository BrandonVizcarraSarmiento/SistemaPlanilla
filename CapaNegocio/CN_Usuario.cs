using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario();
        public Usuario ValidarUsuario(string correo, string clave)
        {
            DataTable dtUsuario = objcd_usuario.ObtenerUsuarioPorCorreoYClave(correo, clave);

            if (dtUsuario.Rows.Count > 0)
            {
                DataRow row = dtUsuario.Rows[0];
                Usuario usuario = new Usuario
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nombre = row["Nombre"].ToString(),
                    Correo = row["Correo"].ToString(),
                    Clave = row["Clave"].ToString()
                };
                return usuario;
            }
            else
            {
                return null;
            }
        }
        public DataTable ObtenerUsuariosConRoles()
        {
                CD_Usuario cdUsuario = new CD_Usuario();
                return cdUsuario.ObtenerUsuariosConRoles();
        }
        public void AgregarUsuario(string nombre, string correo, string clave, int idRol, bool estado)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(correo))
                throw new ArgumentException("El correo no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(clave))
                throw new ArgumentException("La clave no puede estar vacía.");

            objcd_usuario.AgregarUsuario(nombre, correo, clave, idRol, estado);
        }
        public void EditarUsuario(int id, string nombre, string correo, string clave, int idRol, bool estado)
        {
            // Validar que el ID del usuario sea válido
            if (id <= 0)
                throw new ArgumentException("El ID del usuario no es válido.", nameof(id));

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.", nameof(nombre));

            if (string.IsNullOrWhiteSpace(correo))
                throw new ArgumentException("El correo no puede estar vacío.", nameof(correo));

            if (string.IsNullOrWhiteSpace(clave))
                throw new ArgumentException("La clave no puede estar vacía.", nameof(clave));

            try
            {
                // Llamar al método de la capa de datos para editar el usuario
                objcd_usuario.EditarUsuario(id, nombre, correo, clave, idRol, estado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el usuario: " + ex.Message);
            }
        }
    }
}
