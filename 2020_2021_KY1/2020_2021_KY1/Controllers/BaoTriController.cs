using _2020_2021_KY1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2020_2021_KY1.Controllers
{
    public class BaoTriController : Controller
    {
        public IActionResult enternhanvien()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(_2020_2021_KY1.Models.StoreContext)) as StoreContext;
            ViewBag.ListNhanVien = context.GetAllNhanVien();
            return View();
        }
        public IActionResult lietkethietbi(string MaNhanVien)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(_2020_2021_KY1.Models.StoreContext)) as StoreContext;
            ViewBag.ListThietBi = context.GetThietBiTheoNhanVien(MaNhanVien);
            ViewBag.MaNhanVien = MaNhanVien;
            return View();
        }
        public void xoabaotri(string MaNhanVien, string MaThietBi, string MaCanHo, int LanThu)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(_2020_2021_KY1.Models.StoreContext)) as StoreContext;
            int count = context.XoaBaoTri(MaNhanVien, MaThietBi, MaCanHo, LanThu);
        }

        public IActionResult viewbaotri(string MaNhanVien, string MaThietBi, string MaCanHo, int LanThu)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(_2020_2021_KY1.Models.StoreContext)) as StoreContext;
            ViewBag.BaoTri = context.GetBaoTri(MaNhanVien,  MaThietBi, MaCanHo, LanThu);
            return View();
        }
        public IActionResult updatebaotri(NV_BT bt, string MaNhanVien_Old, string MaThietBi_Old, string MaCanHo_Old, int LanThu_Old)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(_2020_2021_KY1.Models.StoreContext)) as StoreContext;
            context.UpdateBaoTri(bt, MaNhanVien_Old, MaThietBi_Old, MaCanHo_Old, LanThu_Old);
            return RedirectToAction("viewbaotri", "BaoTri", new { bt.MaNhanVien, bt.MaThietBi, bt.MaCanHo, bt.LanThu });
        }
        
    }
}
