using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GNBCWeb.Models;
using GNBCWeb.Services;

namespace GNBCWeb.Controllers
{
    public class OrderController : Controller
    {
		readonly OrderService _orderService;

		public OrderController() {
			this._orderService = new OrderService();
		}

		public string LogAddToBasket(string sessionid, int productid) 
		{
			var orderEvent = new OrderLogEventItem
			{
				SessionId = sessionid,
				EventDetail = string.Format("product {0}, added to basket", productid),
				EventType = OrderEventType.AddToPayPalBasket
			};
			_orderService.AddItemToOrderLog(orderEvent);
			return "OK";
		}
    }
}
