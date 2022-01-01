using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using firstWeb.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace firstWeb.Controllers
{
    public class SinhVienController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        /*
        public string XemDiem() {
            return "Đây là  trang web xem điểm sinh viên";
        }*/

       /* public string XemDiem(string name, double diem=9)
        {
            return HtmlEncoder.Default.Encode($"Ten {name} Diem trung binh {diem}");  
        }*/
        /*
        public string XemDiem(string name, double diem=9, int ID=1)
        {
            return HtmlEncoder.Default.Encode($"ID {ID} Ten {name} Diem trung binh {diem}");  
        }*/
        public IActionResult XemDiem(string name, double diem = 9)
        {
            ViewData["name"] = name;
            ViewData["diem"] = diem;
            return View();
        }
        public IActionResult LietKeSinhVien()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(firstWeb.Models.StoreContext)) as StoreContext;

            return View(context.GetSinhViens());

        }
        //Liet ke sinh vien cua bo mon
        public IActionResult LietKeSinhVienCuaBoMon(BoMon bm)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(firstWeb.Models.StoreContext)) as StoreContext;

            return View(context.GetSinhViens(bm.MaBoMon));
            

        }

        public IActionResult XoaSinhVien(SinhVien sv)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(firstWeb.Models.StoreContext)) as StoreContext;
            int count = context.XoaSinhVien(sv.MaSinhVien);
            if (count > 0)
                ViewData["thongbao"] = "Xóa thành công";
            else
                ViewData["thongbao"] = "Xóa không thành công";
            return View();
        }
        public IActionResult TimSinhVien()
        {
            return View();

        }
        public IActionResult TimSinhVienTheoTen(SinhVien sv)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(firstWeb.Models.StoreContext)) as StoreContext;
            int count = context.TimSinhVienTheoTen(sv.TenSinhVien);
            if (count > 0)
                ViewData["thongbao"] = "Tìm thấy";
            else
                ViewData["thongbao"] = "Tìm không thấy";
            return View();
        }
        public IActionResult LietKeNSinhVien() {
            return View();
        }

        public IActionResult LietKeCacSinhVien(int SoSinhVien)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(firstWeb.Models.StoreContext)) as StoreContext;

            return View(context.LietKeNSinhVien(SoSinhVien));
        }

        public IActionResult LietKeSinhVienMax() {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(firstWeb.Models.StoreContext)) as StoreContext;

            return View(context.SinhVienMax());
        }
        
    }
}
