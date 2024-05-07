using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Bancos
    {
        private CD_Bancos objcd_banco = new CD_Bancos();
        public List<Banco> Listar()
        {
            return objcd_banco.Listar();
        }
        public int Registrar(Banco obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre completo del usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_banco.Registrar(obj, out Mensaje);
            }
        }
        public bool Editar(Banco obj, out string Mensaje)
        {

            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre completo del usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_banco.Editar(obj, out Mensaje);
            }
        }
       
    }
}