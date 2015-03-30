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
				Title = "Silver Britannia",
				Description = "<p>The new 2015 Silver Britannia from The Royal Mint. Struck in the finest silver, this iconic coin is ideal for UK based investors due to its status as british legal tender, making it Capital Gains Tax free. The fine silver Britannia remains our most popular bullion coin with those who prefer a more easily divisible portfolio, and is a must for any serious investor looiking to maximise their gains.</p>",
				Price = 18.89,
				Image = "gold coin 700x400.jpg"
			});
		
			Products.Add(new Product()
			{
				Id = 2,
				Title = "Austrian Philharmonic",
				Description = "<p>Silver Austrian Philharmonic. This latest silver bullion coin from the Austrian Mint is made from the purest silver in the world. This coin is popular with investrs and collectors alike. </p>",
				Price = 17.99,
				Image = "gold bar 700x400.jpg"
			});

					Products.Add(new Product()
			{
				Id = 3,
				Title = "Canadian Maple Leaf",
				Description = "<p>The 2015 Canadian Maple Leaf siver bullion coin. The Royal Canadian Mint have sruck the Maple Leaf for 25 years. This is a popular coin with investors and collectors. </p>",
				Price = 19.47,
				Image = "800x300 britannia double.jpg"
			});

					Products.Add(new Product()
			{
				Id = 4,
				Title = "2.5 Gram Silver Bullion Bar",
				Description = "<p></p>",
				Price = 199.99,
				Image = "silver bars 700x400.jpg"
			});
		}
	}
}