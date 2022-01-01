using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaQuangHuy_19520113.Models;

namespace TaQuangHuy_19520113.Controllers
{
    public class NhanVienController : Controller
    {
        public IActionResult EnterNV()
        {
            Context context = HttpContext.RequestServices.GetService(typeof(TaQuangHuy_19520113.Models.Context)) as Context;
            return View(context.GetListNhanVien());
        }

        public IActionResult LietKeHD(string MaNV)
        {
            Context context = HttpContext.RequestServices.GetService(typeof(TaQuangHuy_19520113.Models.Context)) as Context;
            return View(context.GetListHD(MaNV));
        }
        public IActionResult DeleteHD(int SoHD)
        {
            Context context = HttpContext.RequestServices.GetService(typeof(TaQuangHuy_19520113.Models.Context)) as Context;
            int count = context.DeleteHD(SoHD);
            if (count > 0)
                ViewData["thongbao"] = "Xóa thành công";
            else
                ViewData["thongbao"] = "Xóa không thành công";
            return View();
        }
    }
}
