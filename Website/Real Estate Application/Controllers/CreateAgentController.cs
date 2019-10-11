using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Real_Estate_Application.Models;

namespace Real_Estate_Application.Controllers
{
    public class CreateAgentController : Controller
    {
        RealEstateContext context = new RealEstateContext();

        // GET: CreateAgent
        [HttpGet]
        public ActionResult Index()
        {
            string[] Provinces = { "Newfoundland and Labrador", "Nova Scotia", "Prince Edward Island", "New Brunswick", "Quebec", "Ontario", "Manitoba", "Saskatchewan", "Alberta", "British Columbia", "Nunavut", "Northwest Territory", "Yukon" };
            ViewBag.Provinces = Provinces;

            return View();
        }

        // POST: CreateAgent
        [HttpPost]
        public ActionResult Index(Agent agent)
        {
            context.Agents.Add(agent);
            context.SaveChanges();

            return View();
        }
    }
}