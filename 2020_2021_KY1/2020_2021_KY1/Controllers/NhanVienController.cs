using _2020_2021_KY1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2020_2021_KY1.Controllers
{
    public class NhanVienController : Controller
    {
        public IActionResult entersolansua()
        {
            return View();
        }

        public IActionResult lietkenvtheosolansua(int SoLanSua)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(_2020_2021_KY1.Models.StoreContext)) as StoreContext;
            ViewBag.ListNhanVien = context.GetNhanVienTheoSoLanSua(SoLanSua);
            return View();
        }
    }
}
