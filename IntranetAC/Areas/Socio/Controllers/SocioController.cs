using IntranetAC.AccesoDatos.Repositorio.IRepositorio;
using IntranetAC.Areas.Reservacion.Controllers;
using IntranetAC.Areas.Socio.Models;
using IntranetAC.Modelos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IntranetAC.Areas.Socio.Controllers
{
    [Area("Socio")]
    public class SocioController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnidadTrabajo _unidadTrabajo;

        public SocioController(ILogger<HomeController> logger, IUnidadTrabajo unidadTrabajo)
        {
            _logger = logger;
            _unidadTrabajo = unidadTrabajo;
        }

        [Authorize]
        public IActionResult RegistrarSocio()
        {
            SocioModel model = new SocioModel();
            model = llenarComboTipoDocumento(model);
            return View(model);
        }

        [HttpPost]
        public IActionResult Insert(SocioModel model)
        {
            if (ModelState.IsValid)
            {
                Modelos.Socio socio = new Modelos.Socio();
                socio.SocioNombre = model.SocioNombre;
                socio.SocioApellidoPaterno = model.SocioApellidoPaterno;
                socio.SocioApellidoMaterno = model.SocioApellidoMaterno;
                socio.SocioTipoDocumento = model.SocioTipoDocumento;
                socio.SocioNumeroDocumento = model.SocioNumeroDocumento;
                socio.SocioFechaRegistro = DateTime.Now;

                _unidadTrabajo.Socio.Agregar(socio);
                _unidadTrabajo.Guardad();

                return RedirectToAction("RegistrarSocio");
            }
            else
            {
                return View("~/Areas/Socio/Views/Socio/RegistarSocio.cshtml", model);
            }
           
            //model = llenarComboTipoDocumento(model);
            //return View(model);
        }

        private SocioModel llenarComboTipoDocumento(SocioModel model)
        {
            IEnumerable<TipoDocumento> tipoDocumentoLista = _unidadTrabajo.TipoDocumento.ObtenerTodos();
            foreach (TipoDocumento tipoDocumento in tipoDocumentoLista)
            {
                model.TipoDocumento.Add(new TipoDocumentoModel() { TipoDocumentoId = tipoDocumento.TipoDocumentoId, TipoDocumentoDesc = tipoDocumento.TipoDocumentoDesc });
            }
            return model;
        }
    }
}