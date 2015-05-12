﻿using System;
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
				Price = product.Price,
				PayPalButtonId = product.PayPalButtonId
			};

			return productViewModel;
		}


		public List<Product> Products = new List<Product>();

		private void populateProducts() {
			Products.Add(new Product()
			{
				Id = 1,
				Title = "Silver Britannia 2015",
				Description = "<p>The new 2015 Silver Britannia from The Royal Mint. Struck in the finest silver, this iconic coin is ideal for UK based investors due to its status as british legal tender, making it Capital Gains Tax free. The fine silver Britannia remains our most popular bullion coin with those who prefer a more easily divisible portfolio, and is a must for any serious investor looiking to maximise their gains.</p>",
				Price = 18.77,
				Image = "800x300 britannia double.jpg",
				PayPalButtonId = "W3EG3XULVE2W4"
			});
		
			Products.Add(new Product()
			{
				Id = 2,
				Title = "Silver Britannia 2014",
				Description = "<p>The silver Britannia 2014 Horse mark privy. " +
				              "This coin is popular with investors and collectors alike due to its rich history and standing. </p>",
				Price = 19.17,
				Image = "800x300 austrian phil.jpg",
				PayPalButtonId = "7QFCKU4TFB88N"
			});

			//Products.Add(new Product()
			//{
			//	Id = 3,
			//	Title = "Canadian Maple Leaf",
			//	Description = "<p>The 2015 Canadian Maple Leaf siver bullion coin. The Royal Canadian Mint have sruck the Maple Leaf for 25 years. This is a popular coin with investors and collectors. </p>",
			//	Price = 18.47,
			//	Image = "800x300 maple leaf.jpg"
			//});

			//Products.Add(new Product()
			//{
			//	Id = 4,
			//	Title = "2.5 Gram Silver Bullion Bar",
			//	Description = "<p>These minted silver bullion bars from Emirates are ideal for those who prefer smaller denomination bullion. 2.5 grams of fine silver in each bar.</p>",
			//	Price = 5.99,
			//	Image = "800x300 silver bar 2.5g.jpg"
			//});

			//Products.Add(new Product()
			//{
			//	Id = 5,
			//	Title = "5 Gram Silver Bullion Bar",
			//	Description = "<p>These minted silver bullion bars from Emirates are ideal for those who prefer smaller denomination bullion. 5 grams of fine silver in each bar.</p>",
			//	Price = 7.99,
			//	Image = "800x300 silver bar 2.5g.jpg"
			//});

			//Products.Add(new Product()
			//{
			//	Id = 6,
			//	Title = "100 Gram Silver Bullion Bar",
			//	Description = "<p>These minted silver bullion bars from Emirates are ideal for those who prefer smaller denomination bullion. 2.5 Grams of fine silver in each bar.</p>",
			//	Price = 66.81,
			//	Image = "800x300 silver bar 2.5g.jpg"
			//});

			//Products.Add(new Product()
			//{
			//	Id = 7,
			//	Title = "250 Gram Silver Bullion Bar",
			//	Description = "<p>These minted silver bullion bars from Emirates are ideal for those who prefer smaller denomination bullion. 2.5 Grams of fine silver in each bar.</p>",
			//	Price = 147.96,
			//	Image = "800x300 silver bar 2.5g.jpg"
			//});

			//Products.Add(new Product()
			//{
			//	Id = 8,
			//	Title = "500 Gram Silver Bullion Bar",
			//	Description = "<p>These substantial bars are cast with the serious investor in mind. 500 grams of fine silver make these bars a superb store of value.</p>",
			//	Price = 279.77,
			//	Image = "800x300 silver bar.jpg"
			//});

			//Products.Add(new Product()
			//{
			//	Id = 9,
			//	Title = "10oz Silver Bullion Bar",
			//	Description = "<p>These minted silver bullion bars from Emirates are ideal for those who prefer smaller denomination bullion. 2.5 Grams of fine silver in each bar.</p>",
			//	Price = 183.22,
			//	Image = "800x300 silver bar 2.5g.jpg"
			//});

			Products.Add(new Product()
			{
				Id = 10,
				Title = "Gold Sovereign 2015",
				Description = "<p>The Gold sovereign has been an icon of British coinage for over 600 years. Struck in 24 karat gold, with a fine metal content of 7.32 grams, these are a best seller and a favourite coin for UK investors. Enjoy the benefits of Capital Gains Tax exemption on this coin.</p>",
				Price = 221.72,
				Image = "800x300 gold coin.jpg",
				PayPalButtonId = "56KVLUZA9CYTY"
			});

			Products.Add(new Product()
			{
				Id = 11,
				Title = "Gold Bar 1 gram",
				Description = "<p>This is the very cheapest way to buy one gram of Gold. These are our best value bars from either Heraeus or Umicore.</p>",
				Price = 36.95,
				Image = "800x300 gold coin.jpg",
				PayPalButtonId = "8MFRQWF6HE7ZQ"
			});

		}
	}
}


