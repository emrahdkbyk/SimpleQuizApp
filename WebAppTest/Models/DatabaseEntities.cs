using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebAppTest.Models
{
    public class DatabaseEntities:DbContext
    {
        public DatabaseEntities():base("name=MyConnStr")
        {

        }

        public virtual DbSet<Secenek> Secenek { get; set; }
        public virtual DbSet<Soru> Soru { get; set; }
        public virtual DbSet<Sinav> Sinav { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<KullaniciCevap> KullaniciCevap { get; set; }
        public virtual DbSet<KullaniciSinav> KullaniciSinav { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder); 
        }
    }
}