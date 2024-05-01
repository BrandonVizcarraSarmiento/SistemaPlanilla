using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Asistencia
    {
        public int Id { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public int DiasLaborados { get; set; }
        public int DiasNoLaborados { get; set; }
        public int DiasEfectivos { get; set; }
        public Empleado oEmpleado { get; set; }
    }
}