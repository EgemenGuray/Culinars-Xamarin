using Culinars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Products.Controllers
{
    public class ProductController : Controller
    {
        public JsonResult GetList()
        {
            var model = new List<Product>();
            model.Add(new Product() { Id = 1, Name = "Water" });
            model.Add(new Product() { Id = 2, Name = "Potato" });
            model.Add(new Product() { Id = 3, Name = "Tomato" });


            return Json(model, JsonRequestBehavior.AllowGet);
        }
       
    }
}
