using _2020_2021_KY1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2020_2021_KY1.Controllers
{
    public class CanHoController : Controller
    {
        public IActionResult entercanho()
        {

            return View();
        }

        public IActionResult insertcanho(CanHo ch)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(_2020_2021_KY1.Models.StoreContext)) as StoreContext;
            context.InsertCanHo(ch);
            return View("entercanho");
        }
    }
}
