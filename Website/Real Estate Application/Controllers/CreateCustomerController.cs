using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Real_Estate_Application.Models;

namespace Real_Estate_Application.Controllers
{
    public class CreateCustomerController : Controller
    {
        RealEstateContext context = new RealEstateContext();

        // GET: CreateCustomer
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // POST: CreateCustomer
        [HttpPost]
        public ActionResult Index(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();

            return View();
        }
    }
}