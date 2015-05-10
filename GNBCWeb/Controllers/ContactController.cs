using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GNBCWeb.Models;

namespace GNBCWeb.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        public ActionResult Index()
        {
            return View();
        }

		public ActionResult EnquirySuccess(ContactViewModel viewModel)
		{
			
			return View(viewModel);
		}

    }
}
