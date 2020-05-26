using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppTest.Models
{
    public class Sinav
    {
        public Sinav()
        {
            this.Sorular = new HashSet<Soru>();
            this.KullaniciSinavlari = new HashSet<KullaniciSinav>();
        }
        public int SinavId { get; set; }
        public string SinavAd { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Soru> Sorular { get; set; }
        public virtual ICollection<KullaniciSinav> KullaniciSinavlari { get; set; }
    }
}