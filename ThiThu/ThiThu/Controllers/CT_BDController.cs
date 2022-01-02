using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThiThu.Models;

namespace ThiThu.Controllers
{
    public class CT_BDController : Controller
    {
        public IActionResult xemctbd(string MaBD)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(ThiThu.Models.StoreContext)) as StoreContext;
            List<object> list = context.getctbd(MaBD);
            ViewBag.listctbd = list;
            ViewBag.thanhtien = list.Sum(p => (int)p.GetType().GetProperty("DonGia").GetValue(p, null));
            return View();
        }
        public void xoactbd(string MaCV, string MaBD)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(ThiThu.Models.StoreContext)) as StoreContext;
            context.xoactbd(MaCV, MaBD);
        }

    }
}
