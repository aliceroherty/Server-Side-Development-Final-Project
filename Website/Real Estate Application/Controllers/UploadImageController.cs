using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Real_Estate_Application.Models;
using System.IO;
using System.Globalization;

namespace Real_Estate_Application.Controllers
{
    public class UploadImageController : Controller
    {
        RealEstateContext context = new RealEstateContext();

        // GET: UploadImage
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // POST: UploadImage
        [HttpPost]
        public ActionResult Index(Image image, HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                try
                {
                    string path = Path.Combine(Server.MapPath("~/Content/UploadedImages"), Path.GetFileName(file.FileName));
                    file.SaveAs(path);

                    ModelState.Remove("FilePath");
                    image.FilePath = path;

                    ModelState.Remove("FileName");
                    image.FileName = Path.GetFileName(file.FileName);

                    image.UploadDateTime = DateTime.Now;

                    //TODO: Get StaffMemberID
                    image.StaffMemberID = 1;

                    if (ModelState.IsValid)
                    {
                        context.Images.Add(image);
                        int rowsAffected = context.SaveChanges();

                        if (rowsAffected > 0)
                        {
                            ViewBag.Message = "Upload Successful.";
                        }
                        else
                        {
                            ViewBag.Message = "Upload Failed.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "Error: " + ex.Message.ToString();
                }
            }
            else
            {
                ViewBag.Message = "You must specify a file to upload.";
            }

            return View();
        }
    }
}