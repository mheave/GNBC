using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GNBCWeb.Domain;
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
			var defaultProductId = _productService.GetProducts().FirstOrDefault().Id;
            return RedirectToAction("Details",new {productId = defaultProductId});
        }

		public ActionResult Details(int? productId)
		{
			if(!productId.HasValue)
				return View("Index");

			var productDetails = _productService.GetProductFromId((int)productId);
			if (productDetails == null)
				return View("Index");

			productDetails.ProductSelectMenuItems = ProductMenu(productDetails.ProductId);
			return View("Details", productDetails);
		}

		public List<ProductSelectMenuItem> ProductMenu(int selectedItem) {
			var productList = _productService.GetProducts().OrderBy(x=>(int)x.OrderPosition);
			var productMenuItemList = productList.Select(product => new ProductSelectMenuItem
			{
				ProductId = product.Id, LinkText = product.Title, IsSelected = (product.Id == selectedItem)
			}).ToList();

			return productMenuItemList;
		}
    }
			
}
