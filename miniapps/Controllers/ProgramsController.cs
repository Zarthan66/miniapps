using Microsoft.AspNetCore.Mvc;
using miniapps.Models;
using miniapps.Services;

namespace miniapps.Controllers
{
    public class ProgramsController : Controller
    {
        SorterServices sorterServ;

        public ProgramsController()
        {
            sorterServ = new SorterServices();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sorter(string submit, SorterModel sorter)
        {
            switch(submit)
            {
                case "sortColumn":
                    sorter.textOutput = sorterServ.SortColumn(sorter);
                    break;
                case "sortRow":
                    sorter.textOutput = sorterServ.SortRow(sorter);
                    break;
            }
            return View(sorter);
        }
    }
}
