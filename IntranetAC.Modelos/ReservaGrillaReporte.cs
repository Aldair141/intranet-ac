using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntranetAC.Modelos
{
    public class ReservaGrillaReporte : Reserva
    {
        public Socio objSocio { get; set; }
        public Area objArea { get; set; }
    }
}