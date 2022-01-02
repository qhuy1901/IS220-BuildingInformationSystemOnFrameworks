using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThiThu.Models;

namespace ThiThu.Controllers
{
    public class BaoDuongController : Controller
    {
        public IActionResult entersoxe()
        {
            return View();
        }

        public IActionResult lietkebaoduong(string SoXe)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(ThiThu.Models.StoreContext)) as StoreContext;
            ViewBag.listbaoduong = context.getlistbaoduong(SoXe);
            return View();
        }
        public IActionResult xembaoduong(string MaBD)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(ThiThu.Models.StoreContext)) as StoreContext;
            ViewBag.baoduonginfo = context.getbaoduonginfo(MaBD);
            return View();
        }

        public IActionResult suabaoduong(string MaBD, BaoDuong bd)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(ThiThu.Models.StoreContext)) as StoreContext;
            context.suabaoduong(MaBD, bd);
            return RedirectToAction("xembaoduong", "BaoDuong", new { MaBD = MaBD });
        }
    }
}
