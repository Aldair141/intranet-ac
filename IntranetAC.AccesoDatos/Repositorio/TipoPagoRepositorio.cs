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
    public class TipoPagoRepositorio : Repositorio<TipoPago>, ITipoPagoRepositorio
    {
        private readonly ApplicationDbContext _db;

        public TipoPagoRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}