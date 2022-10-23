using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntranetAC.Modelos
{
    public class Membresia
    {
        public int MembresiaId { get; set; }
        public int SocioId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public int MembresiaEstado { get; set; }
    }
}