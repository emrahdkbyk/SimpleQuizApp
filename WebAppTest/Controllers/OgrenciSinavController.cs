using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppTest.Models;

namespace WebAppTest.Controllers
{
    public class OgrenciSinavController : Controller
    {
        private DatabaseEntities db = new DatabaseEntities();
        // GET: OgrenciSinav
        public ActionResult Index()
        {
            ViewBag.SinavId = new SelectList(db.Sinav, "SinavId", "SinavAd");
            return View();
        }

        [HttpPost]
        public ActionResult Index(int SinavId)
        {
            Session["SinavId"] = SinavId.ToString();
            Sinav sinav = db.Sinav.Where(s => s.SinavId == SinavId).FirstOrDefault();
            Session["SinavAd"] = sinav.SinavAd;
            Session["KullaniciId"] = "12345";
            
            return RedirectToAction("TestOl");
        }

        public ActionResult TestOl ()
        {
            IList<Soru> sorular = null;
            
            int id = Convert.ToInt32(Session["SinavId"]);
             ViewBag.SinavAd= Session["SinavAd"];
            sorular = db.Soru.Where(s => s.SinavId == id).ToList();
            if(sorular!=null)
                return View(sorular);
            return View();

        }

        [HttpPost]
        public ActionResult TestOl(FormCollection formCollection)
        {
            if(formCollection.Count == 0)
            {

            }

            int secenekId; //radiobutton value
            int puan = 0;
            foreach (var item in formCollection) //item radiobutton name e sahip
            {
                secenekId = int.Parse(ValueProvider.GetValue(item.ToString()).AttemptedValue);  //itemdan value değerini alıyoruz
                
                if (db.Secenek.Find(secenekId).DogruCevapmi == true)
                    
                    puan += db.Secenek.Find(secenekId).Soru.PuanDegeri;

            }
            Session["PuanDegeri"] = puan.ToString();
                
            return RedirectToAction("TestSonuc");

        }

        public ActionResult TestSonuc()
        {
            return View();
        }

        
      

    }
}