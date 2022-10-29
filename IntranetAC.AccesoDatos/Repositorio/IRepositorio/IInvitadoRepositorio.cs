using IntranetAC.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntranetAC.AccesoDatos.Repositorio.IRepositorio
{
    public interface IInvitadoRepositorio : IRepositorio<Invitado>
    {
        IEnumerable<Invitado> ObtenerInvitadosPorReserva(int reservaid);
    }
}