using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using firstWeb.Models;
using MySql.Data.MySqlClient;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace firstWeb.Controllers
{
    public class KhoaController : Controller
    {
        //dùng thuộc tính Model để trả về ViewModel
        /*
        public IActionResult Index()
        {
            ViewData.Model = new Khoa("MK11","Mạng máy tính");

            return View();
        }*/
        public IActionResult Index()
        {
            ViewData["Khoa"] = new Khoa("MK11", "Mạng máy tính");
            return View();
        }

        // cách dùng ViewBag 
     /*
        public IActionResult Index()
        {
            ViewBag.Khoa = new Khoa("MK10","Hệ thống Thông tin");
            return View();
        }
        */
        /* trả về 1 chuoi cho View Index, View Index không cần lấy giá trị trả về
        public IActionResult Index()
        {
            string str = "Trường Đại Học CNTT";
            return Content(str);
        }*/

        //gọi View có tên EnterKhoa trong 
        public IActionResult EnterKhoa() {
            return View();     
        }

        public IActionResult InsertKhoa(Khoa kh)
        {
            int count;

            //StoreContext context = HttpContext.RequestServices.GetService(typeof(firstWeb.Models.StoreContext)) as StoreContext;
            StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=qlsv;");
            count = context.InsertKhoa(kh);

            if (count > 0)
                ViewData["thongbao"] = "Insert thành công";
            else
                ViewData["thongbao"] = "Insert không thành công";
            return View();
        }
        public IActionResult UpdateKhoa(Khoa kh) {
            int count;
            StoreContext context = HttpContext.RequestServices.GetService(typeof(firstWeb.Models.StoreContext)) as StoreContext;
            count = context.UpdateKhoa(kh);
            if (count > 0)
                ViewData["thongbao"] = "Update thành công";
            else
                ViewData["thongbao"] = "Update không thành công";
            return View();
        }

        public IActionResult LietKeKhoa()
        {

            StoreContext context = HttpContext.RequestServices.GetService(typeof(firstWeb.Models.StoreContext)) as StoreContext;

            //StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=qlsv;");
            return View(context.GetKhoas());
        }

        public IActionResult DeleteKhoa(string Id) {
           // ViewData["id"] = Id;
            StoreContext context = HttpContext.RequestServices.GetService(typeof(firstWeb.Models.StoreContext)) as StoreContext;
            int count = context.XoaKhoa(Id);
            if (count > 0)
                ViewData["thongbao"] = "Xóa thành công";
            else
                ViewData["thongbao"] = "Xóa không thành công";
            return View();
        }
        public IActionResult ViewKhoa(string Id)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(firstWeb.Models.StoreContext)) as StoreContext;
            Khoa kh = context.ViewKhoa(Id);
            ViewData.Model = kh;
            return View();
        }
        /*
        public IActionResult InsertKhoa(Khoa kh)
        {
            string message = "";
            if (ModelState.IsValid)
            {
                message = "Mã khoa:" + kh.MaKhoa + " Tên khoa" + kh.TenKhoa + " created successfully";
            }
            else
            {
                message = "Failed to create the khoa. Please try again";
            }
            return Content(message);
        }*/

       
    }
}