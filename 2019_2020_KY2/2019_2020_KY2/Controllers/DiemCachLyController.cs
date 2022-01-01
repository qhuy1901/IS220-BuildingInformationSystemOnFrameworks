using _2019_2020_KY2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2019_2020_KY2.Controllers
{
    public class DiemCachLyController : Controller
    {
        public IActionResult enterdcl()
        {
            return View();
        }

        public IActionResult themdcl(DiemCachLy dcl)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(_2019_2020_KY2.Models.StoreContext)) as StoreContext;
            context.themdcl(dcl);
            return View("enterdcl");
        }

        public IActionResult lietke_theoten()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(_2019_2020_KY2.Models.StoreContext)) as StoreContext;
            ViewBag.AllDiemCachLy = context.getAllDiemCachLy();
            return View();
        }

    }
}
