using LAB05.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB05.Controllers
{
    public class XeController : Controller
    {
        public IActionResult LietKeXe()
        {
            Context context = HttpContext.RequestServices.GetService(typeof(LAB05.Models.Context)) as Context;
            return View(context.GetListXe());
        }

        public IActionResult ViewXe(string MaXe)
        {
            Context context = HttpContext.RequestServices.GetService(typeof(LAB05.Models.Context)) as Context;
            Xe xe = context.GetXeInfo(MaXe);
            ViewData.Model = xe;
            return View();
        }

        public IActionResult UpdateXe(Xe xe)
        {
            System.Diagnostics.Debug.WriteLine(xe.MaXe);
            Context context = HttpContext.RequestServices.GetService(typeof(LAB05.Models.Context)) as Context;
            int count = context.UpdateXe(xe);
            if (count > 0)
                ViewData["thongbao"] = "Update xe thành công";
            else
                ViewData["thongbao"] = "Update xe không thành công";
            return View();
        }

        public IActionResult DeleteXe(string MaXe)
        {
            Context context = HttpContext.RequestServices.GetService(typeof(LAB05.Models.Context)) as Context;
            int count = context.DeleteXe(MaXe);
            if (count > 0)
                ViewData["thongbao"] = "Xóa xe thành công";
            else
                ViewData["thongbao"] = "Xóa xe không thành công";
            return View();
        }
    }
}
