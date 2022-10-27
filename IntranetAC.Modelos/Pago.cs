using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntranetAC.Modelos
{
    public class Pago
    {
        public int PagoId { get; set; }
        public int TipoPagoId { get; set; }
        public int SocioId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal MontoCancela { get; set; }
        public decimal MontoRecibido { get; set; }
        public decimal Vuelto { get; set; }
    }
}
