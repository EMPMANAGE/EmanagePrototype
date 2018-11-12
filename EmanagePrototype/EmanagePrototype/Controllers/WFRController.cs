using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmanagePrototype.Controllers
{
    public class WFRController : Controller
    {
        // GET: WFR
        public ActionResult WFRDetails()
        {
            ViewBag.Message = "Your WFR page.";

            return View();
        }
    }
}