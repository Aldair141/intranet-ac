using System.ComponentModel.DataAnnotations;

namespace IntranetAC.Areas.Membresia.Models
{
    public class PagoModel
    {
        public int SocioId { get; set; }
        public int TipoPagoId { get; set; }
        public decimal MontoCancela { get; set; }
        public decimal MontoRecibido { get; set; }
        public decimal Vuelto { get; set; }
        public List<TipoPagoModel> TipoPago { get; set; }

    }
}