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
    public class UnidadLongitudRepositorio : Repositorio<UnidadLongitud>, IUnidadLongitudRepositorio
    {
        private readonly ApplicationDbContext _db;
        public UnidadLongitudRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}