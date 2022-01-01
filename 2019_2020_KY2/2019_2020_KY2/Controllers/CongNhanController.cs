using _2019_2020_KY2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2019_2020_KY2.Controllers
{
    public class CongNhanController : Controller
    {
        public IActionResult lietke_congnhan(string MaDiemCachLy)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(_2019_2020_KY2.Models.StoreContext)) as StoreContext;
            ViewBag.listCongNhan = context.getCN(MaDiemCachLy);
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
        public void delete_congnhan(string MaCongNhan)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(_2019_2020_KY2.Models.StoreContext)) as StoreContext;
            context.delete_congnhan(MaCongNhan);
        }
        public IActionResult view_congnhan(string MaCongNhan)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(_2019_2020_KY2.Models.StoreContext)) as StoreContext;
            ViewBag.CongNhan = context.getCNInfo(MaCongNhan);
            return View();
        }
    }
}
