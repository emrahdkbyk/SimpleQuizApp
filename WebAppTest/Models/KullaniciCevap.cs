using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppTest.Models
{
    public class KullaniciCevap
    {
        public int KullaniciCevapId { get; set; }
        [ForeignKey("Kullanici")]
        public int KullaniciId { get; set; }
        [ForeignKey("Secenek")]
        public int SecenekId { get; set; }
        public DateTime CevapZamani { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual Secenek Secenek { get; set; }
    }
}