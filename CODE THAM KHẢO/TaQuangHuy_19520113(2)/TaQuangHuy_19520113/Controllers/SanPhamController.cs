using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaQuangHuy_19520113.Models;

namespace TaQuangHuy_19520113.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult EnterSanPham()
        {
            return View();
        }

        public IActionResult InsertSanPham(SanPham kh)
        {
            int count;
            Context context = HttpContext.RequestServices.GetService(typeof(TaQuangHuy_19520113.Models.Context)) as Context;
            count = context.InsertSanPham(kh);

            if (count > 0)
                ViewData["thongbao"] = "Insert thành công";
            else
                ViewData["thongbao"] = "Insert không thành công";
            return View();
        }
        public IActionResult LietKeNSP(int SoSanPham)
        {
            return View();

        }
        public IActionResult LietKeCacSanPham(int SoSanPham)
        {
            Context context = HttpContext.RequestServices.GetService(typeof(TaQuangHuy_19520113.Models.Context)) as Context;

            return View(context.LietKeNSP(SoSanPham));

        }
    }
}
