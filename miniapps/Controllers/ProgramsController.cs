using Microsoft.AspNetCore.Mvc;

namespace miniapps.Controllers
{
    public class ProgramsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sorter()
        {
            return View();
        }
    }
}
