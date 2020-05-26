using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppTest.Models
{
    public class Kullanici
    {
        public Kullanici()
        {
            this.KullaniciCevaplari = new HashSet<KullaniciCevap>();
            this.KullaniciSinavlari = new HashSet<KullaniciSinav>();
        }
        public int KullaniciId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime KayitTarihi { get; set; }

        public virtual ICollection<KullaniciCevap> KullaniciCevaplari { get; set; }
        public virtual ICollection<KullaniciSinav> KullaniciSinavlari { get; set; }
    }
}