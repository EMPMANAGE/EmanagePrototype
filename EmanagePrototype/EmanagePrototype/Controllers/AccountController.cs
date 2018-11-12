using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmanagePrototype.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult AccountDetails()
        {
            ViewBag.Message = "Your Account page.";

            return View();
        }
    }
}