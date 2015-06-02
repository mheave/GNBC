using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace GNBCWeb.Domain {
	public class Product {
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string Image { get; set; }
		public string PayPalButtonId { get; set; }
		public int OrderPosition { get; set; }
	}

	public class ProductSelectMenuItem {
		public int ProductId { get; set; }
		public string LinkText { get; set; }
		public bool IsSelected { get; set; }
		public int Order { get; set; }
		
	}

}