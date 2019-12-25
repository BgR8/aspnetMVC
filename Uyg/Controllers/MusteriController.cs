using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Uyg.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        public string getirTumMusteri()
        {
            return @"<ul>
              <li>Ali Veli</li>
              <li>Ahmet Mehmet</li>
              <li>Ayşe Fatma</li>
           </ul>";
        }
    }
}