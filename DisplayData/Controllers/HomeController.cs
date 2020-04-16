using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DisplayData.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            try
            {
                ViewBag.Title = "Home Page";

                return View();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return View("Error.cshtml");
            }
        }
    }
}
