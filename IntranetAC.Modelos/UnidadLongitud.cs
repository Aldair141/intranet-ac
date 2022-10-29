using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntranetAC.Modelos
{
    public class UnidadLongitud
    {
        [Key]
        public int AreaLongitudId { get; set; }
        public string AreaLongitudDesc { get; set; }
        public string AreaLongitudAbreviatura { get; set; }
    }
}