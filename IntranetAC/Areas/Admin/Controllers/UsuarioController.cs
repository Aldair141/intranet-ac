using IntranetAC.AccesoDatos.Repositorio.IRepositorio;
using Microsoft.AspNetCore.Mvc;

namespace IntranetAC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsuarioController : Controller
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        public UsuarioController(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region API
        [HttpGet]
        public IActionResult obtenerTodos()
        {
            var todos = _unidadTrabajo.UsuarioAplicacion.ObtenerTodos();
            return Json(new {data=todos});
        }


        #endregion


    }
}
