using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XXWindow.ViewModel;

namespace XXWindow.Controllers
{
    public class XxDoorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ProductShow()
        {
            return View();
        }

        public JsonResult GetProductByPage(int Page)
        {
            var i = Page.ToString();
            ProductVM products = new ProductVM();
            products.Total = new Random().Next(20, 100);
            var model = new List<ProductPageModel>()
            {
                new ProductPageModel(){ ImgSrc = i },
                new ProductPageModel(){ ImgSrc = i },
                new ProductPageModel(){ ImgSrc = i },
                new ProductPageModel(){ ImgSrc = i },
                 new ProductPageModel(){ ImgSrc = i },
                new ProductPageModel(){ ImgSrc = i },
                new ProductPageModel(){ ImgSrc = i },
                new ProductPageModel(){ ImgSrc = i },
            };

            products.Products = model;
            return new JsonResult(products);
        }
    }

   

}