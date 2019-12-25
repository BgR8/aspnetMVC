using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Uyg.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        /*public string index()
        {
            return "Merhaba Dünya, bu ASP.NET MVC Uygulamasıdır";
        }*/
        public ActionResult Index()
        {
            return RedirectToAction("getirTumMusteri", "Musteri");
        }
    }
}