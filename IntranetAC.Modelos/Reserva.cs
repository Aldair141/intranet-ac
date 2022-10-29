using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntranetAC.Modelos
{
    public class Reserva
    {
        public int ReservaId { get; set; }
        public int SocioId { get; set; }
        public int AreaId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int EstadoReserva { get; set; }
    }
}
