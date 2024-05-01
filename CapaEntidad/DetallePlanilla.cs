using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetallePlanilla
    {
        public int Id { get; set; }
        public decimal MontoConcepto { get; set; }
        public ResumenPlanilla oResumenPlanilla { get; set; }
        public Concepto oConcepto { get; set; }
    }
}