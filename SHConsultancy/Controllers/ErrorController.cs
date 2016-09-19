using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SHConsultancy.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            ViewBag.Header = "";
            ViewBag.Body = "ERROR OCCURED";
            return View();
        }

        public ActionResult NotFound()
        {
            ViewBag.Header = "404";
            ViewBag.Body = "PAGE NOT FOUND";
            return View("Index");
        }
    }
}