using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fuurkanjpg.Models.Siniflar;

namespace Fuurkanjpg.Controllers
{
    public class ContactController : Controller
    {
        Context c = new Context();
        // GET: Contact
        //public ActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(Iletisim f)
        {
            c.Iletisims.Add(f);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}