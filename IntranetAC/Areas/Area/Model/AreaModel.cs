namespace IntranetAC.Areas.Area.Model
{
    public class AreaModel
    {
        public int AreaId { get; set; }
        public string AreaDescripcion { get; set; }
        public string AreaLongitud { get; set; }
        public string UnidadLongitud { get; set; }
        public bool AreaEstadoId { get; set; }
        public string AreaCaracteristicas { get; set; }
        public List<UnidadLongitudModel> UnidadesLongitud { get; set; }
    }
}
