using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntranetAC.Modelos
{
    public class Area
    {
        public int AreaId { get; set; }
        public string AreaDescripcion { get; set; }
        public string AreaLongitud { get; set; }
        public string UnidadLongitud { get; set; }
        public int AreaEstadoId { get; set; }
        public string AreaCaracteristicas { get; set; }
    }
}