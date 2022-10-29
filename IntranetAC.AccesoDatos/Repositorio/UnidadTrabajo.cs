using IntranetAC.AccesoDatos.Data;
using IntranetAC.AccesoDatos.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntranetAC.AccesoDatos.Repositorio
{
    public class UnidadTrabajo : IUnidadTrabajo
    {
        private readonly ApplicationDbContext _db;
        public IUsuarioAplicacionRepositorio UsuarioAplicacion { get; private set; }
        public ITipoDocumentoRepository TipoDocumento { get; private set; }
        public ISocioRepositorio Socio { get; private set; }
        public IMembresiaRepositorio Membresia { get; private set; }
        public ITipoPagoRepositorio TipoPago { get; private set; }
        public IPagoRepositorio Pago { get; private set; }
        public IAreaEstadoRepositorio AreaEstado { get; private set; }
        public IAreaRepositorio Area { get; private set; }
        public IUnidadLongitudRepositorio UnidadLongitud { get; private set; }
        public IReservaRepositorio Reserva { get; private set; }
        public IInvitadoRepositorio Invitado { get; private set; }

        public UnidadTrabajo(ApplicationDbContext db)
        {
            _db = db;
            UsuarioAplicacion = new UsuarioAplicacionRepositorio(_db);
            TipoDocumento = new TipoDocumentoRepositorio(_db);
            Socio = new SocioRepositorio(_db);
            Membresia = new MembresiaRepositorio(_db);
            TipoPago = new TipoPagoRepositorio(_db);
            Pago = new PagoRepositorio(_db);
            AreaEstado = new AreaEstadoRepositorio(_db);
            Area = new AreaRepositorio(_db);
            UnidadLongitud = new UnidadLongitudRepositorio(_db);
            Reserva = new ReservaRepositorio(_db);
            Invitado = new InvitadoRepositorio(_db);
        }


        public void Dispose()
        {
            _db.Dispose();
        }

        public void Guardad()
        {
            _db.SaveChanges();
        }
    }
}
