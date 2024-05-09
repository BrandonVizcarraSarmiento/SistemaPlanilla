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

    }
}
