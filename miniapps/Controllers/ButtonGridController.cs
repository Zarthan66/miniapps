using Microsoft.AspNetCore.Mvc;
using miniapps.Models;

namespace miniapps.Controllers
{
    public class ButtonGridController : Controller
    {
        static List<ButtonGridModel> buttons = new List<ButtonGridModel>();
        Random random = new Random();
        const int GRID_SIZE = 25;

        public IActionResult Index()
        {
            if(buttons.Count == 0)
            {
                for (int i = 0; i < GRID_SIZE; i++)
                {
                    buttons.Add(new ButtonGridModel { Id = i, State = random.Next(4) });
                }
            }       
            return View("Index", buttons);
        }

        public IActionResult HandleButtonClick(string buttonNumber)
        {
            // convert from string into int
            int btn = int.Parse(buttonNumber);

            buttons.ElementAt(btn).State = (buttons.ElementAt(btn).State + 1) % 4;
            return View("index", buttons);
        }
    }
}
