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

        void Guardad();
    }
}
