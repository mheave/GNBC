using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace GNBCWeb.ViewModels {
	public class ProductViewModel {
		
		public string Title { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public string Image { get; set; }
		public int ProductId {get; set;}
		public string PayPalButtonId { get; set;}


	}
}