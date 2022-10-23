using IntranetAC.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntranetAC.AccesoDatos.Repositorio.IRepositorio
{
    public interface IMembresiaRepositorio : IRepositorio<Membresia>
    {
        IEnumerable<MembresiaSocio> ObtenerMembresiasSocios();
        void Actualizar(Membresia membresia);
    }
}