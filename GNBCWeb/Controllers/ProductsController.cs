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
	    readonly ProductService _productService;

		public ProductsController() {
			_productService = new ProductService();
		}

        public ActionResult Index()
        {
            return RedirectToAction("Details",new {productId = 3});
        }

		public ActionResult Details(int? productId)
		{
			if(!productId.HasValue)
				return View("Index");

			var productDetails = _productService.GetProductFromId((int)productId);
			if (productDetails == null)
				return View("Index");

			return View("Details", productDetails);
		}
			
    }
}
