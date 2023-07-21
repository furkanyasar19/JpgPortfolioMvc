using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fuurkanjpg.Models.Siniflar;

namespace Fuurkanjpg.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        Context c = new Context();

        public ActionResult Index()
        {
            var degerler = c.Headers.ToList();
            return View(degerler);
        }
        public PartialViewResult FotoPartial()
        {
            var degerler = c.Fotolars.ToList();
            return PartialView(degerler);
        }
        public PartialViewResult GunSozPartial()
        {
            var degerler = c.GununSozus.ToList();
            return PartialView(degerler);
        }
    }
}