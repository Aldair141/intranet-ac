using Microsoft.AspNetCore.Mvc;

namespace IntranetAC.Areas.Area.Controllers
{
    [Area("Area")]
    public class AreaController : Controller
    {
        public IActionResult RegistrarArea()
        {
            return View();
        }
    }
}
