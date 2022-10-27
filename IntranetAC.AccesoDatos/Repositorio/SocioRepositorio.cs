using IntranetAC.AccesoDatos.Data;
using IntranetAC.AccesoDatos.Repositorio.IRepositorio;
using IntranetAC.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntranetAC.AccesoDatos.Repositorio
{
    public class SocioRepositorio : Repositorio<Socio>, ISocioRepositorio
    {
        private readonly ApplicationDbContext _db;

        public SocioRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Socio ObtenerSocioPorDocumento(string documento)
        {
            //Socio socio = _db.Socio.Where(x => x.SocioNumeroDocumento.Equals(documento)).First();
            Socio socio = _db.Socio.FirstOrDefault(x => x.SocioNumeroDocumento.Equals(documento));
            return socio;
        }
    }
}
