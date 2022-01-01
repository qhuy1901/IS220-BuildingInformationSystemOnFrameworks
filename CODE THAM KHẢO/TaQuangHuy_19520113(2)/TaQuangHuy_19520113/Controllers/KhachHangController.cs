using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaQuangHuy_19520113.Models;

namespace TaQuangHuy_19520113.Controllers
{
    public class KhachHangController : Controller
    {
        public IActionResult LietKeKH()
        {
            Context context = HttpContext.RequestServices.GetService(typeof(TaQuangHuy_19520113.Models.Context)) as Context;
            return View(context.GetListKhachHang());
        }

        public IActionResult ViewKhachHang(string MaKH)
        {
            System.Diagnostics.Debug.WriteLine(MaKH);
            Context context = HttpContext.RequestServices.GetService(typeof(TaQuangHuy_19520113.Models.Context)) as Context;
            KhachHang kh = context.ViewKhachHang(MaKH);
            ViewData.Model = kh;
            return View();
        }

        public IActionResult UpdateKhachHang(KhachHang kh)
        {
            int count;
            Context context = HttpContext.RequestServices.GetService(typeof(TaQuangHuy_19520113.Models.Context)) as Context;
            count = context.UpdateKhachHang(kh);
            if (count > 0)
                ViewData["thongbao"] = "Update thành công";
            else
                ViewData["thongbao"] = "Update không thành công";
            return View();
        }

        public IActionResult DeleteKhachHang(string MaKH)
        {
            Context context = HttpContext.RequestServices.GetService(typeof(TaQuangHuy_19520113.Models.Context)) as Context;
            int count = context.DeleteKhachHang(MaKH);
            if (count > 0)
                ViewData["thongbao"] = "Xóa thành công";
            else
                ViewData["thongbao"] = "Xóa không thành công";
            return View();
        }
        public IActionResult EnterKhachHang()
        {
            return View();
        }

        public IActionResult InsertKhachHang(KhachHang kh)
        {
            int count;
            Context context = new Context("server=127.0.0.1;user id=root;password=;port=3307;database=quanlybanhang;");
            count = context.InsertKhachHang(kh);

            if (count > 0)
                ViewData["thongbao"] = "Insert thành công";
            else
                ViewData["thongbao"] = "Insert không thành công";
            return View();
        }

        //Đếm số sinh viên trong từng bộ môn
        public IActionResult DemSoHD()
        {
            Context context = HttpContext.RequestServices.GetService(typeof(TaQuangHuy_19520113.Models.Context)) as Context;
            return View(context.SoHoaDonKhachHang());
        }
    }
}
