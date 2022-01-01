using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaQuangHuy_19520113.Models;

namespace TaQuangHuy_19520113.Controllers
{
    public class HoaDonController : Controller
    {
        public IActionResult EnterHoaDon()
        {
            Context context = HttpContext.RequestServices.GetService(typeof(TaQuangHuy_19520113.Models.Context)) as Context;
            ViewBag.ListNhanVien = context.GetListNhanVien();
            return View(context.GetListKhachHang());
        }

        public IActionResult InsertHoaDon(HoaDon hd)
        {
            int count;
            Context context = HttpContext.RequestServices.GetService(typeof(TaQuangHuy_19520113.Models.Context)) as Context;
            count = context.InsertHoaDon(hd);
            if (count > 0)
                ViewData["thongbao"] = "Insert thành công";
            else
                ViewData["thongbao"] = "Insert không thành công";
            return View();
        }

        
    }
}
