using LAB05.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB05.Controllers
{
    public class KhachHangController : Controller
    {
        public IActionResult LietKeKH()
        {
            Context context = HttpContext.RequestServices.GetService(typeof(LAB05.Models.Context)) as Context;
            return View(context.GetListKhachHang());
        }

        public IActionResult TimKhachHang()
        {
            return View();
        }

        

        public IActionResult TimKhachHangTheoTen(KhachHang kh)
        {
            Context context = HttpContext.RequestServices.GetService(typeof(LAB05.Models.Context)) as Context;
            int count = context.TimKhachHangTheoTen(kh.HoTen);
            if (count > 0)
                ViewData["thongbao"] = "Tìm thấy";
            else
                ViewData["thongbao"] = "Tìm không thấy";
            return View();
        }
        public IActionResult EnterKhachHang()
        {
            return View();
        }

        public IActionResult InsertKhachHang(KhachHang kh)
        {
            Context context = HttpContext.RequestServices.GetService(typeof(LAB05.Models.Context)) as Context;
            int count = context.InsertKhachHang(kh);

            if (count > 0)
                ViewData["thongbao"] = "Insert khách hàng thành công";
            else
                ViewData["thongbao"] = "Insert khách hàng không thành công";
            return View();
        }
    }
}
