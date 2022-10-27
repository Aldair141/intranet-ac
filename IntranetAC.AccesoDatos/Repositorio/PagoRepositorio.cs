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
    public class PagoRepositorio : Repositorio<Pago>, IPagoRepositorio
    {
        private readonly ApplicationDbContext _db;

        public PagoRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<PagoGrillaReporte> ObtenerPagoReporte()
        {
            var listaSocios = _db.Socio.ToList();
            var listaTipoPago = _db.TipoPago.ToList();
            var listaPagos = _db.Pago.ToList();

            IEnumerable<PagoGrillaReporte> lstPago = (from a in listaPagos
                                                      join b in listaTipoPago on a.PagoId equals b.TipoPagoId
                                                      join c in listaSocios on a.SocioId equals c.SocioId
                                                      select new PagoGrillaReporte
                                                      {
                                                          FechaRegistro = a.FechaRegistro,
                                                          MontoCancela = a.MontoCancela,
                                                          MontoRecibido = a.MontoRecibido,
                                                          PagoId = a.PagoId,
                                                          SocioId = a.SocioId,
                                                          SocioNombreCompleto = $"{ c.SocioNombre } { c.SocioApellidoPaterno } { c.SocioApellidoMaterno }",
                                                          TipoPagoDescripcion = b.TipoPagoDesc,
                                                          TipoPagoId = a.TipoPagoId,
                                                          Vuelto = a.Vuelto 
                                                      });
            return lstPago;
        }
    }
}