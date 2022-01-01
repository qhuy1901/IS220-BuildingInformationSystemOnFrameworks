using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using firstWeb.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace firstWeb.Controllers
{
    public class BoMonController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EnterBoMon()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(firstWeb.Models.StoreContext)) as StoreContext;
            return View(context.GetKhoas());
        }
        public IActionResult InsertBoMon(BoMon bm)
        {
            int count;
            StoreContext context = HttpContext.RequestServices.GetService(typeof(firstWeb.Models.StoreContext)) as StoreContext;
            count = context.InsertBoMon(bm);
            if (count > 0)
                ViewData["thongbao"] = "Insert thành công";
            else
                ViewData["thongbao"] = "Insert không thành công";
            return View();
        }
        public IActionResult LietKeBoMon()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(firstWeb.Models.StoreContext)) as StoreContext;

            return View(context.GetBoMons());
        }

        //Đếm số sinh viên trong từng bộ môn
        public IActionResult SoSinhVien()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(firstWeb.Models.StoreContext)) as StoreContext;

            return View(context.SoSinhVienTrongBoMon());
        }

    }
}
