using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GNBCWeb.Controllers
{
    public class PaymentController : Controller
    {
        //
        // GET: /Payment/

        public ActionResult Success()
        {
            return View();
        }

		public ActionResult Failure() {
			return View();
		}

    }
}
