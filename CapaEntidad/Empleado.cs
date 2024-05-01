using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Empleado
    {
        public int Id { get; set; }
        public string DNI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string FechaInicioContrato { get; set; }
        public string FechaFinContrato { get; set; }
        public string CuentaBancaria { get; set; }
        public Banco oBanco { get; set; }
        public FondoPension oFondoPension { get; set; }
        public Cargo oCargo { get; set; }
    }
}