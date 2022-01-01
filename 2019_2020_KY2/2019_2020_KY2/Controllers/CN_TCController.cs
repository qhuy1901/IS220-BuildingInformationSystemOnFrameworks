using _2019_2020_KY2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2019_2020_KY2.Controllers
{
    public class CN_TCController : Controller
    {
        public IActionResult liet_ke(int SoTrieuChung)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(_2019_2020_KY2.Models.StoreContext)) as StoreContext;
            ViewBag.ListCN = context.lietke(SoTrieuChung);
            return View();
        }
        public IActionResult entersott()
        { return View(); }

    }
}
