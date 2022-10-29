using IntranetAC.Areas.Area.Model;
using IntranetAC.Areas.Socio.Models;

namespace IntranetAC.Areas.Reservacion.Model
{
    public class ReservaModel
    {
        public int ReservaId { get; set; }
        public int SocioId { get; set; }
        public string SocioNombre { get; set; }
        public int AreaId { get; set; }
        public string AreaDescripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int EstadoReserva { get; set; }
        public List<SocioModel> Socios { get; set; }
        public List<AreaModel> Areas { get; set; }
    }
}
