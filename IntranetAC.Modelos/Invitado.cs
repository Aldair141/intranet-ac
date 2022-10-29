using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntranetAC.Modelos
{
    public class Invitado
    {
        [Key]
        public int InvitadoId { get; set; }
        public int ReservaId { get; set; }
        public int InvitadoTipoDocumento { get; set; }
        public string InvitadoNroDocumento { get; set; }
        public string InvitadoNombre { get; set; }
        public string InvitadoApellidoPaterno { get; set; }
        public string InvitadoApellidoMaterno { get; set; }
    }
}