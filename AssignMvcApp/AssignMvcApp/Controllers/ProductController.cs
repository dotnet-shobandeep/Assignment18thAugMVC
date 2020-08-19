using AssignMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignMvcApp.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult ProIndex()
        {
            var product = GetProductDetails();

            return View(product);
        }
        private IEnumerable<Products> GetProductDetails()
        {
            return new List<Products>
            {
                new Products{Product_Id=101, Product_Name="AC", Rate=45000},
                 new Products{Product_Id=102, Product_Name="Mobile", Rate=38000},
                  new Products{Product_Id=103, Product_Name="Bike", Rate=94000}
            };
        }
        public ActionResult Details(int id)
        {
            var pro = GetProductDetails().SingleOrDefault(c => c.Product_Id == id);
            if (pro == null)
                return HttpNotFound();
            return View(pro);
        }
    }
}