using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppTest.Models
{
    public class Secenek
    {
        public Secenek()
        {
            this.KullaniciCevaplari = new HashSet<KullaniciCevap>();
        }
        public int SecenekId { get; set; }
        public string SecenekMetni { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public int Sira { get; set; }
        public bool DogruCevapmi { get; set; }

        [ForeignKey("Soru")]
        public int SoruId { get; set; }
        public virtual Soru Soru { get; set; }
        public virtual ICollection<KullaniciCevap> KullaniciCevaplari { get; set; }
    }
}