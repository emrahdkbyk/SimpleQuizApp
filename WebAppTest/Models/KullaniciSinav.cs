using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppTest.Models
{
    public class KullaniciSinav
    {
        public int KullaniciSinavId { get; set; }
        [ForeignKey("Kullanici")]
        public int KullaniciId { get; set; }
        [ForeignKey("Sinav")]
        public int SinavId { get; set; }
        public DateTime BaslamaZamani { get; set; }
        public DateTime BitisZamani { get; set; }
        public int TestPuani { get; set; }

        public virtual Kullanici Kullanici { get; set; }
        public virtual Sinav Sinav { get; set; }
    }
}