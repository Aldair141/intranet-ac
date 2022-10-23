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
    public class MembresiaRepositorio : Repositorio<Membresia>, IMembresiaRepositorio
    {
        private readonly ApplicationDbContext _db;
        public MembresiaRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Actualizar(Membresia membresia)
        {
            var membresiaDB = _db.Membresia.FirstOrDefault(x => x.MembresiaId == membresia.MembresiaId);
            if (membresiaDB != null)
            {
                membresiaDB.MembresiaEstado = membresia.MembresiaEstado;
                membresiaDB.FechaAlta = membresia.FechaAlta;
                membresiaDB.FechaBaja = membresia.FechaBaja;
            }
        }

        public IEnumerable<MembresiaSocio> ObtenerMembresiasSocios()
        {
            var listaSocios = _db.Socio.ToList();
            var listaEstados = _db.MembresiaEstado.ToList();

            var listaMembresia = _db.Membresia.ToList();

            IEnumerable<MembresiaSocio> lstMembresia = (from a in listaMembresia
                                                   join b in listaSocios on a.SocioId equals b.SocioId
                                                   join c in listaEstados on a.MembresiaEstado equals c.MembresiaEstadoId
                                                   select new MembresiaSocio
                                                   {
                                                       MembresiaId = a.MembresiaId,
                                                       SocioId = a.SocioId,
                                                       SocioNombre = $"{ b.SocioNombre } { b.SocioApellidoPaterno } { b.SocioApellidoMaterno }",
                                                       FechaRegistro = a.FechaRegistro,
                                                       FechaAlta = a.FechaAlta,
                                                       FechaBaja = a.FechaBaja,
                                                       MembresiaEstado = a.MembresiaEstado,
                                                       MembresiaEstadoDesc = c.MembresiaEstadoDescripcion
                                                   });
            return lstMembresia;
        }
    }
}
