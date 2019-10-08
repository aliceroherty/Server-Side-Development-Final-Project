using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Real_Estate_Application.Controllers
{
    public class CreateCustomerController : Controller
    {
        // GET: CreateCustomer
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}