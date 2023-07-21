using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fuurkanjpg.Models.Siniflar;

namespace Fuurkanjpg.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Fotolars.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniFoto()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniFoto(Fotolar f)
        {
            c.Fotolars.Add(f);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult FotoSil(int id)
        {
            var sil = c.Fotolars.Find(id);
            c.Fotolars.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        //Günün Sözü
        public ActionResult GunSoz()
        {
            var degerler = c.GununSozus.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniSoz()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSoz(GununSozu f)
        {
            c.GununSozus.Add(f);
            c.SaveChanges();
            return RedirectToAction("GunSoz");
        }
        public ActionResult GunSozSil(int id)
        {
            var sil = c.GununSozus.Find(id);
            c.GununSozus.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("GunSoz");
        }
        //Hakkimda
        public ActionResult Hakkimda()
        {
            var degerler = c.Hakkimdas.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniHakkimda()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniHakkimda(Hakkimda f)
        {
            c.Hakkimdas.Add(f);
            c.SaveChanges();
            return RedirectToAction("Hakkimda");
        }
        public ActionResult HakkimdaSil(int id)
        {
            var sil = c.Hakkimdas.Find(id);
            c.Hakkimdas.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("Hakkimda");
        }
        //Iletisim
        public ActionResult Iletisim()
        {
            var degerler = c.Iletisims.ToList();
            return View(degerler);
        }
        public ActionResult IletisimSil(int id)
        {
            var sil = c.Iletisims.Find(id);
            c.Iletisims.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("Iletisim");
        }
    }
}