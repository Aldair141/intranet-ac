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
    public class ReservaRepositorio : Repositorio<Reserva>, IReservaRepositorio
    {
        private readonly ApplicationDbContext _db;
        public ReservaRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<ReservaGrillaReporte> ObtenerReservaReporte()
        {
            var socios = _db.Socio;
            var areas = _db.Area;
            var reservas = _db.Reserva;

            IEnumerable<ReservaGrillaReporte> lstReserva = (from a in reservas
                                                            join b in socios on a.SocioId equals b.SocioId
                                                            join c in areas on a.AreaId equals c.AreaId
                                                            select new ReservaGrillaReporte
                                                            {
                                                                AreaId = a.AreaId,
                                                                SocioId = b.SocioId,
                                                                EstadoReserva = a.EstadoReserva,
                                                                FechaRegistro = a.FechaRegistro,
                                                                ReservaId = a.ReservaId,
                                                                objArea = c,
                                                                objSocio = b
                                                            });
            return lstReserva;
        }
    }
}