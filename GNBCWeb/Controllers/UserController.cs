using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GNBCWeb.Controllers
{
    public class UserController : Controller
    {

          //
        // POST: /User/Create

        [HttpPost]
        public ActionResult SignUp(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return View();
            }
            catch
            {
                return View();
            }
        }

 
    }
}
