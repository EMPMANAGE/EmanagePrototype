using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmanagePrototype.Controllers
{
    public class FinanceController : Controller
    {
        // GET: Finance
        public ActionResult FinanceDetails()
        {
            ViewBag.Message = "Your Finance page.";

            return View();
        }
    }
}