using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using GNBCWeb.Domain;

namespace GNBCWeb.ViewModels {
	public class ProductMenuViewModel {
		public List<ProductSelectMenuItem> ProductSelectMenuItems { get; set; }
	}
}