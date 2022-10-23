using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntranetAC.Modelos
{
    public class TipoDocumento
    {
        [Key]
        public int TipoDocumentoId { get; set; }
        public string TipoDocumentoDesc { get; set; }
    }
}
