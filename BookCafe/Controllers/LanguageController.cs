using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Globalization;

namespace BookCafe.Controllers
{
    public class LanguageController : Controller
    {
        // GET: Language
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Change(String Language)
        {
            if (Language != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(Language);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(Language);
            }
            HttpCookie cookie = new HttpCookie("language");
            cookie.Value = Language;
            Response.Cookies.Add(cookie);

            return RedirectToAction("Index");
        }
    }
}