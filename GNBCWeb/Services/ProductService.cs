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
				Description = "Some desciptive text about Gold",
				Price = 199.99,
				Image = "gold coin 700x400.jpg"
			});

			Products.Add(new Product()
			{
				Id = 2,
				Title = "Gold bars",
				Description = "Some desciptive text about Gold bars",
				Price = 199.99,
				Image = "gold bar 700x400.jpg"
			});

					Products.Add(new Product()
			{
				Id = 3,
				Title = "Silver coins",
				Description = "Some desciptive text about silver",
				Price = 199.99,
				Image = "800x300 britannia double.jpg"
			});

					Products.Add(new Product()
			{
				Id = 4,
				Title = "Silver bars",
				Description = "Some desciptive text about silver",
				Price = 199.99,
				Image = "silver bars 700x400.jpg"
			});
		}
	}
}