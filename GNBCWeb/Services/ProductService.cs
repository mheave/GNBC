using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Web;
using GNBCWeb.Data;
using GNBCWeb.ViewModels;
using System.Web.Mvc;
using Product = GNBCWeb.Domain.Product;

namespace GNBCWeb.Services {
	public class ProductService {
		readonly GoldSilverMoneyDbDataContext gsbdbDataContext =  new GoldSilverMoneyDbDataContext();

		public ProductViewModel GetProductFromId(int id) {
			var product = GetProducts().FirstOrDefault(p=>p.Id == id);

			var productViewModel = new ProductViewModel()
			{
				ProductId = product.Id,
				Title = product.Title,
				Description =  product.Description,
				Price = product.Price,
				PayPalButtonId = product.PayPalButtonId

			};

			return productViewModel;
		}

		public IEnumerable<Product> GetProducts() {
			var productsFromDb = (from product in gsbdbDataContext.Products select new Product
			{
				Id= product.productId,
				Title = product.Title,
				Description = product.Description,
				Price = product.PriceInGbp,
				PayPalButtonId = product.PayPalButtonId,
				OrderPosition = product.OrderPosition ?? 0
			});
			return productsFromDb;
		}

}
}


