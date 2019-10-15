using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Real_Estate_Application.Controllers
{
    public class ViewListingController : Controller
    {
        // GET: ViewListing
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}