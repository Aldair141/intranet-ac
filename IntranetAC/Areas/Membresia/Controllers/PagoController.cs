using Microsoft.AspNetCore.Mvc;

namespace IntranetAC.Areas.Membresia.Controllers
{
    [Area("Membresia")]
    public class PagoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}