using LAB05.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB05.Controllers
{
    public class HopDongController : Controller
    {
        public IActionResult EnterKhachHang()
        {
            Context context = HttpContext.RequestServices.GetService(typeof(LAB05.Models.Context)) as Context;
            return View(context.GetListKhachHang());
        }

        public IActionResult LietKeHD(string MaKH)
        {
            Context context = HttpContext.RequestServices.GetService(typeof(LAB05.Models.Context)) as Context;
            KhachHang kh = context.GetKhachHangInfo(MaKH);
            ViewBag.TenKH = kh.HoTen;
            return View(context.GetListHD(MaKH));
        }
    }
}
