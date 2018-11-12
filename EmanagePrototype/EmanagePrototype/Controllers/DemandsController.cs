using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmanagePrototype.Controllers
{
    public class DemandsController : Controller
    {
        // GET: Demands
        public ActionResult DemandsDetails()
        {
            ViewBag.Message = "Your Demand page.";

            return View();
        }
    }
}