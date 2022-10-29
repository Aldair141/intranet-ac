using IntranetAC.AccesoDatos.Repositorio.IRepositorio;
using IntranetAC.Areas.Area.Model;
using IntranetAC.Areas.Socio.Models;
using IntranetAC.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace IntranetAC.Areas.Area.Controllers
{
    [Area("Area")]
    public class AreaController : Controller
    {
        private readonly IUnidadTrabajo _db;
        public AreaController(IUnidadTrabajo db)
        {
            _db = db;
        }

        public IActionResult RegistrarArea()
        {
            IEnumerable<UnidadLongitud> unidadLongitud = _db.UnidadLongitud.ObtenerTodos();

            AreaModel areaModel = new AreaModel();
            areaModel.UnidadesLongitud = new List<UnidadLongitudModel>();

            foreach (var item in unidadLongitud)
            {
                areaModel.UnidadesLongitud.Add(new UnidadLongitudModel
                {
                    AreaLongitudId = item.AreaLongitudId,
                    AreaLongitudDesc = item.AreaLongitudDesc,
                    AreaLongitudAbreviatura = item.AreaLongitudAbreviatura
                });
            }

            return View(areaModel);
        }

        [HttpPost]
        public IActionResult Insert(AreaModel model)
        {
            try
            {
                Modelos.Area area = new Modelos.Area();
                area.AreaDescripcion = model.AreaDescripcion;
                area.AreaLongitud = model.AreaLongitud;
                area.UnidadLongitud = model.UnidadLongitud;
                area.AreaEstadoId = (model.AreaEstadoId) ? 1 : 2;
                area.AreaCaracteristicas = model.AreaCaracteristicas;

                _db.Area.Agregar(area);
                _db.Guardad();

                return RedirectToAction("RegistrarArea");
            }
            catch
            {
                return View("~/Areas/Area/Views/Area/RegistrarArea.cshtml", model);
            }
        }
    }
}
