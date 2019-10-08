using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Real_Estate_Application.Controllers
{
    public class CreateAgentController : Controller
    {
        // GET: CreateAgent
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}