using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ResumenPlanilla
    {
        public int Id { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public decimal TotalNeto { get; set; }
        public decimal TotalIngresos { get; set; }
        public decimal TotalEgresos { get; set; }
        public Empleado oEmpleado { get; set; }
    }
}