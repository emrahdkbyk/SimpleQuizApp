using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppTest.Models
{
    public class Soru
    {
        public Soru()
        {
            this.Secenekler = new HashSet<Secenek>();
        }
        public int SoruId { get; set; }
        public string SoruMetni { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        
        public int PuanDegeri { get; set; }

        [ForeignKey("Sinav")]
        public int SinavId { get; set; }
        public virtual Sinav Sinav { get; set; }

        public virtual ICollection<Secenek> Secenekler { get; set; }
    }
}