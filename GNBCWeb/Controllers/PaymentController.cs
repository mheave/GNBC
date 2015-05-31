using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GNBCWeb.Models;
using GNBCWeb.Services;

namespace GNBCWeb.Controllers
{
    public class PaymentController : Controller
    {
		readonly OrderService _orderService;

		public PaymentController() {
			this._orderService = new OrderService();
		}

        //
        // GET: /Payment/

        public ActionResult Success()
        {
			var orderEvent = new OrderLogEventItem
			{
				EventType = OrderEventType.PayPalSuccess,
				EventDetail = "Paypal Success page hit",
				SessionId = (HttpContext.Session["_gsbm_session"] != null) ? HttpContext.Session["_gsbm_session"].ToString() : ""
			};
			_orderService.AddItemToOrderLog(orderEvent);
            return View();
        }

		public ActionResult Failure() {
			var orderEvent = new OrderLogEventItem
			{
				EventType = OrderEventType.PayPalFailure,
				EventDetail = "Paypal failure page hit",
				SessionId = (HttpContext.Session["_gsbm_session"] != null) ? HttpContext.Session["_gsbm_session"].ToString() : ""
			};
			_orderService.AddItemToOrderLog(orderEvent);
			return View();
		}

    }
}
