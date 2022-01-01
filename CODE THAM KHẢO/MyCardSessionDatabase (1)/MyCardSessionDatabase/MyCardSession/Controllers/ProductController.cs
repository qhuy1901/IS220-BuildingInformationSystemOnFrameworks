using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCardSession.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyCardSession.Controllers
{
    public class ProductController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ProductModel context = HttpContext.RequestServices.GetService(typeof(MyCardSession.Models.ProductModel)) as ProductModel;
            //ProductModel productModel = new ProductModel();
            ViewBag.products = context.findAll();
            return View();
        }
    }
}
