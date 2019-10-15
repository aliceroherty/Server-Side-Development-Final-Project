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
            if (ModelState.IsValid)
            {
                context.Agents.Add(agent);
                int rowsAffected = context.SaveChanges();

                if (rowsAffected > 0)
                {
                    ViewBag.Message = "Creation Successful.";
                    ModelState.Clear();
                }
                else
                {
                    ViewBag.Message = "Creation Failed.";
                    ModelState.Clear();
                }
            }

            return Index();
        }
    }
}