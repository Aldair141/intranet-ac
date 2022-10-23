using IntranetAC.AccesoDatos.Repositorio.IRepositorio;
using IntranetAC.Areas.Membresia.Models;
using IntranetAC.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace IntranetAC.Areas.Membresia.Controllers
{
    [Area("Membresia")]
    public class MembresiaController : Controller
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        public MembresiaController(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegistrarMembresia()
        {
            IEnumerable<MembresiaSocio> listaMiembros = _unidadTrabajo.Membresia.ObtenerMembresiasSocios();
            return View(listaMiembros);
        }
        [HttpGet]
        public IActionResult BuscarSocio(int SocioID)
        {
            Modelos.Socio socio = _unidadTrabajo.Socio.Obtener(SocioID);
            return Ok(socio);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] MembresiaModel Socio)
        {
            DateTime fechaActual = DateTime.Now;
            Modelos.Membresia membresia = new Modelos.Membresia();
            membresia.SocioId = Socio.SocioId;
            membresia.FechaRegistro = fechaActual;
            membresia.FechaAlta = fechaActual;
            membresia.FechaBaja = fechaActual;
            membresia.MembresiaEstado = 1;

            _unidadTrabajo.Membresia.Agregar(membresia);
            _unidadTrabajo.Guardad();

            return Ok(new { ok = true, message = "Este socio ya se registró como miembro de manera satisfactoria." });
        }

        [HttpGet]
        public IActionResult ListarMiembros()
        {
            var listaMiembros = _unidadTrabajo.Membresia.ObtenerMembresiasSocios();
            return Ok(listaMiembros);
        }

        [HttpDelete]
        public IActionResult DarDeBaja([FromBody] MembresiaModel membresiaParam)
        {
            Modelos.Membresia membresia = _unidadTrabajo.Membresia.Obtener(membresiaParam.MembresiaId);
            membresia.FechaBaja = DateTime.Now;
            membresia.MembresiaEstado = 2;
            _unidadTrabajo.Membresia.Actualizar(membresia);
            _unidadTrabajo.Guardad();

            return Ok(new { ok = true, message = "Este socio ya se dió de baja de manera satisfactoria." });
        }
    }
}
