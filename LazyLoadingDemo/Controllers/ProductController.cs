using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LazyLoadingDemo.Controllers
{
    public class ProductController : Controller
    {
        private ProductRepository productRepository;
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ProductList(int? pageNumber)
        {
            productRepository = new ProductRepository();
            var model = productRepository.GetProducts(pageNumber);
            return PartialView("~/Views/Product/ProductList.cshtml", model);
        }
    }
}