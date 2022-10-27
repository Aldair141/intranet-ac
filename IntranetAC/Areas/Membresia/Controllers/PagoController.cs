using IntranetAC.AccesoDatos.Repositorio.IRepositorio;
using IntranetAC.Areas.Membresia.Models;
using IntranetAC.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace IntranetAC.Areas.Membresia.Controllers
{
    [Area("Membresia")]
    public class PagoController : Controller
    {
        private readonly IUnidadTrabajo _unidadTrabajo;
        public PagoController(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }

        public IActionResult Index()
        {
            List<TipoPago> tiposPago = _unidadTrabajo.TipoPago.ObtenerTodos().ToList();

            PagoModel pm = new PagoModel();
            List<TipoPagoModel> tpModel = new List<TipoPagoModel>();
            foreach (TipoPago item in tiposPago)
            {
                tpModel.Add(new TipoPagoModel() { TipoPagoId = item.TipoPagoId, TipoPagoDesc = item.TipoPagoDesc });
            }

            pm.TipoPago = tpModel;

            return View(pm);
        }

        public IActionResult Insert(PagoModel model)
        {
            if (!ModelState.IsValid)
            {
                List<TipoPago> tiposPago = _unidadTrabajo.TipoPago.ObtenerTodos().ToList();
                List<TipoPagoModel> tpModel = new List<TipoPagoModel>();
                foreach (TipoPago item in tiposPago)
                {
                    tpModel.Add(new TipoPagoModel() { TipoPagoId = item.TipoPagoId, TipoPagoDesc = item.TipoPagoDesc });
                }

                model.TipoPago = tpModel;

                return View("~/Areas/Membresia/Views/Pago/Index.cshtml", model);
            }

            Pago oPago = new Pago();
            oPago.TipoPagoId = model.TipoPagoId;
            oPago.SocioId = model.SocioId;
            oPago.FechaRegistro = DateTime.Now;
            oPago.MontoCancela = model.MontoCancela;
            oPago.MontoRecibido = model.MontoRecibido;
            oPago.Vuelto = model.Vuelto;

            _unidadTrabajo.Pago.Agregar(oPago);
            _unidadTrabajo.Guardad();

            return RedirectToAction("Index");   
        }

        [HttpGet]
        public IActionResult GetSocioPorDocumento(string documento)
        {
            Modelos.Socio objSocio = _unidadTrabajo.Socio.ObtenerSocioPorDocumento(documento);
            return Json(objSocio);
        }

        public IActionResult ListaPagos()
        {
            IEnumerable<PagoGrillaReporte> pagoGrillaReporte = _unidadTrabajo.Pago.ObtenerPagoReporte();
            return View(pagoGrillaReporte);
        }
    }
}