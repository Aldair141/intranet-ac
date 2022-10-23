using System.ComponentModel.DataAnnotations;

namespace IntranetAC.Areas.Socio.Models
{
    public class SocioModel
    {
        public SocioModel()
        {
            this.TipoDocumento = new List<TipoDocumentoModel>();
        }
        [Display(Name = "Nombre")]
        [Required]
        public string SocioNombre { get; set; }

        [Display(Name = "Apellido Paterno")]
        [Required]
        public string SocioApellidoPaterno { get; set; }

        [Display(Name = "Apellido Materno")]
        [Required]
        public string SocioApellidoMaterno { get; set; }

        [Display(Name = "Tipo de Documento")]
        [Range(minimum: 1, maximum: int.MaxValue, ErrorMessage = "Seleccione un DNI")]
        public int SocioTipoDocumento { get; set; }


        [Display(Name = "N° Documento")]
        [MinLength(8, ErrorMessage = "Debe tener un mínimo de 8 caracteres")]
        public string SocioNumeroDocumento { get; set; }

        public List<TipoDocumentoModel> TipoDocumento { get; set; }
    }
}