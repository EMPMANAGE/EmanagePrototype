using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmanagePrototype.Controllers
{
    public class MetricsController : Controller
    {
        // GET: Metrics
        public ActionResult MetricsDetails()
        {
            ViewBag.Message = "Your Metrics page.";

            return View();
        }
    }
}