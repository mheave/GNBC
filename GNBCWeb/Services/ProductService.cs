using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GNBCWeb.Domain;
using GNBCWeb.ViewModels;

namespace GNBCWeb.Services {
	public class ProductService {

		public ProductViewModel GetProductFromId(int id) {
			populateProducts();
			var productFilter = (from p in Products where p.Id==id select p);
			if (!productFilter.Any())
				return null;
			var product = productFilter.FirstOrDefault();
			
			var productViewModel = new ProductViewModel()
			{
				ProductId = product.Id,
				Title = product.Title,
				Description =  product.Description,
				Image = product.Image,
				Price = product.Price

			};

			return productViewModel;
		}


		public List<Product> Products = new List<Product>();

		private void populateProducts() {
			Products.Add(new Product()
			{
				Id = 1,
				Title = "Gold coins",
				Description = "<p>Some desciptive text about Gold</p>",
				Price = 199.99,
				Image = "gold coin 700x400.jpg"
			});

			Products.Add(new Product()
			{
				Id = 2,
				Title = "Gold bars",
				Description = "<p>Some desciptive text about Gold bars</p>",
				Price = 19.37,
				Image = "gold bar 700x400.jpg"
			});

					Products.Add(new Product()
			{
				Id = 3,
				Title = "Silver coins",
				Description = "<p>The 2015 1 oz Silver Britannia bullion coin. Minted in the finest silver, the new 2015 Britannia is perfect for investment or as a great unusual gift.</p><p>With a face value of two pounds, the legal tender Britannia enjoys freedom from Capital Gains Tax, making these coins extremely attractive for UK based investors.</p>",
				Price = 19.37,
				Image = "800x300 britannia double.jpg"
			});

					Products.Add(new Product()
			{
				Id = 4,
				Title = "Silver bars",
				Description = "<p>Some desciptive text about silver</p>",
				Price = 199.99,
				Image = "silver bars 700x400.jpg"
			});
		}
	}
}