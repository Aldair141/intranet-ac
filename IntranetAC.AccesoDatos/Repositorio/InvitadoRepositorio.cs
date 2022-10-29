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
    public class InvitadoRepositorio : Repositorio<Invitado>, IInvitadoRepositorio
    {
        private readonly ApplicationDbContext _db;
        public InvitadoRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<Invitado> ObtenerInvitadosPorReserva(int reservaid)
        {
            return _db.Invitado.Where(x => x.ReservaId == reservaid);
        }
    }
}