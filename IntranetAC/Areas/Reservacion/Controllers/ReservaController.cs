using IntranetAC.AccesoDatos.Repositorio.IRepositorio;
using IntranetAC.Areas.Area.Model;
using IntranetAC.Areas.Reservacion.Model;
using IntranetAC.Areas.Socio.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntranetAC.Areas.Reservacion.Controllers
{
    [Area("Reservacion")]
    public class ReservaController : Controller
    {
        private readonly IUnidadTrabajo _db;
        public ReservaController(IUnidadTrabajo unidadTrabajo)
        {
            _db = unidadTrabajo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GenerarReserva()
        {
            ReservaModel reservaModel = new ReservaModel();
            reservaModel.Areas = new List<AreaModel>();
            reservaModel.Socios = new List<SocioModel>();

            var areasDB = _db.Area.ObtenerTodos();
            var sociosDB = _db.Socio.ObtenerTodos();

            foreach (var area in areasDB)
            {
                reservaModel.Areas.Add(new AreaModel
                {
                    AreaId = area.AreaId,
                    AreaDescripcion = area.AreaDescripcion
                });
            }

            foreach (var socio in sociosDB)
            {
                reservaModel.Socios.Add(new SocioModel
                {
                    SocioId = socio.SocioId,
                    SocioApellidoMaterno = socio.SocioApellidoMaterno,
                    SocioApellidoPaterno = socio.SocioApellidoPaterno,
                    SocioNombre = socio.SocioNombre
                });
            }

            return View("~/Areas/Reservacion/Views/Reserva/Insert.cshtml", reservaModel);
        }

        [HttpPost]
        public IActionResult Insert(ReservaModel model)
        {
            Modelos.Reserva reserva = new Modelos.Reserva();
            reserva.AreaId = model.AreaId;
            reserva.SocioId = model.SocioId;
            reserva.FechaRegistro = DateTime.Now;
            reserva.EstadoReserva = 1;

            _db.Reserva.Agregar(reserva);
            _db.Guardad();

            return RedirectToAction("GenerarReserva");
        }
    }
}
