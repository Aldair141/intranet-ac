using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntranetAC.Modelos
{
    public class Socio
    {
        [Key]
        public int SocioId { get; set; }
        public string SocioNombre { get; set; }
        public string SocioApellidoPaterno { get; set; }
        public string SocioApellidoMaterno { get; set; }
        public int SocioTipoDocumento { get; set; }
        public string SocioNumeroDocumento { get; set; }
        public DateTime SocioFechaRegistro { get; set; }
    }
}
