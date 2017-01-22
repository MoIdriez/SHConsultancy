using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SHConsultancy.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs
        public ActionResult Index()
        {
            return View(new ContactUs());
        }

        public ActionResult SendEmail(ContactUs model)
        {
            return View("Index", new ContactUs());
        }

        public class ContactUs
        {
            [Required]
            public string FirstName { get; set; }
            [Required]
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            [Required]
            public string EmailAddress { get; set; } 
            public string CountryID { get; set; } 
            public string Message { get; set; }
            public List<SelectListItem> Countries => GetCountries();
        }

        public class Country
        {
            public string ID { get; set; }
            public string Name { get; set; }
        }

        public static List<SelectListItem> GetCountries()
        {
            var countries = CultureInfo.GetCultures(CultureTypes.SpecificCultures)
                .Select(x => new Country
                {
                    ID = new RegionInfo(x.LCID).Name,
                    Name = new RegionInfo(x.LCID).EnglishName
                })
                .GroupBy(c => c.ID)
                .Select(c => c.First())
                .OrderBy(x => x.Name);
            return countries.Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.ID
            }).ToList();
        }
    }
}