using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GNBCWeb.Services;
using GNBCWeb.ViewModels;

namespace GNBCWeb.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Product/
		ProductService productService;

		public ProductsController() {
			productService = new ProductService();
		}

        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Details(int? productId)
		{
			if(!productId.HasValue)
				return View("Index");

			var productDetails = productService.GetProductFromId((int)productId);

			return View("Details", productDetails);
		}
			
    }
}
