using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntranetAC.AccesoDatos.Repositorio.IRepositorio
{
    public interface IUnidadTrabajo:IDisposable
    {
        IUsuarioAplicacionRepositorio UsuarioAplicacion { get; }
        ITipoDocumentoRepository TipoDocumento { get; }
        ISocioRepositorio Socio { get; }
        IMembresiaRepositorio Membresia { get; }
        ITipoPagoRepositorio TipoPago { get; }
        IPagoRepositorio Pago { get; }
        IAreaEstadoRepositorio AreaEstado { get; }
        IAreaRepositorio Area { get; }
        IUnidadLongitudRepositorio UnidadLongitud { get; }
        IReservaRepositorio Reserva { get; }
        IInvitadoRepositorio Invitado { get; }
        void Guardad();
    }
}
