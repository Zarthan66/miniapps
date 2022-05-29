using Bogus;
using Microsoft.AspNetCore.Mvc;
using miniapps.Models;
using miniapps.Services;

namespace miniapps.Controllers
{
    public class ProductController : Controller
    {
        
        public IActionResult Index()
        {
            HardCodedSampleDataRepository sample = new HardCodedSampleDataRepository();

            return View(sample.GetAllProducts());
        }
    }
}
