using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fuurkanjpg.Models.Siniflar;

namespace Fuurkanjpg.Controllers
{
    public class AboutController : Controller
    {

        Context c = new Context();

        public ActionResult Index()
        {
            var degerler = c.Hakkimdas.ToList();
            return View(degerler);
        }
    }
}