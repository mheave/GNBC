using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GNBCWeb.Models {
	public class OrderLogEventItem {
		public string SessionId { get; set; }
		public OrderEventType EventType { get; set; }
		public string EventDetail { get; set; }
	}

	public enum OrderEventType {
		AddToPayPalBasket = 1,
		PayPalSuccess = 2,
		PayPalFailure = 3
	}
}