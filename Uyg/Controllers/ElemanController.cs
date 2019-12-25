using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Uyg.Controllers
{
    public class ElemanController : Controller
    {
        // GET: Eleman
        public ActionResult Arama(string isim)
        {
            var input = Server.HtmlEncode(isim);
            return Content(input);
        }
    }
}