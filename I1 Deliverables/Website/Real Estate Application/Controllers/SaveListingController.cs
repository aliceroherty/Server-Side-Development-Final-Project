using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Real_Estate_Application.Controllers
{
    public class SaveListingController : Controller
    {
        // GET: SaveListing
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        //GET: CustomerResults
        [HttpGet]
        public ActionResult CustomerResults()
        {
            return View();
        }

        //GET: CustomerListings
        [HttpGet]
        public ActionResult CustomerListings()
        {
            return View();
        }

        //GET: SaveNewListing
        [HttpGet]
        public ActionResult SaveNewListing()
        {
            return View();
        }

        //GET: SaveListingDetails
        [HttpGet]
        public ActionResult SaveListingDetails()
        {
            return View();
        }

        //GET: AddImage
        [HttpGet]
        public ActionResult AddImage()
        {
            return View();
        }
    }
}