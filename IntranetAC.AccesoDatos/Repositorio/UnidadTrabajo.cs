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
        

        public UnidadTrabajo(ApplicationDbContext db)
        {
            _db = db;
            UsuarioAplicacion = new UsuarioAplicacionRepositorio(_db);
            TipoDocumento = new TipoDocumentoRepositorio(_db);
            Socio = new SocioRepositorio(_db);
            Membresia = new MembresiaRepositorio(_db);
            TipoPago = new TipoPagoRepositorio(_db);
            Pago = new PagoRepositorio(_db);
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
