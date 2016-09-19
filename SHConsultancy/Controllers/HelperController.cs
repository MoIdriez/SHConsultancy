using System;
using System.Web.Mvc;
using SHConsultancy.Helpers;

namespace SHConsultancy.Controllers
{
    public class HelperController : Controller
    {
        // GET: Helper
        public ActionResult SendNewsLetterEmail(string email)
        {
            var message = "This person has asked to be added to the emailing list: " + email;
            EmailHelper.Send("Subscribing for news letter", message);
            return Redirect(ControllerContext.HttpContext.Request.UrlReferrer.ToString());

        }

        // GET: Helper
        public ActionResult SendEmail(string name, string email, string body)
        {
            var message = "Mr/Ms " + name + " with the email, " + email + ", has send you the following message:" + Environment.NewLine + body;
            EmailHelper.Send("Contacting you", message);
            return Redirect(ControllerContext.HttpContext.Request.UrlReferrer.ToString());
        }
    }
}