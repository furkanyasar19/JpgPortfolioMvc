using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;//Paket yöneticisinden Entity Framework indirmek lazım

namespace Fuurkanjpg.Models.Siniflar
{
    public class Context : DbContext //Veri Tabanı oluşturma
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Fotolar> Fotolars { get; set; }
        public DbSet<GununSozu> GununSozus { get; set; }
        public DbSet<Hakkimda> Hakkimdas { get; set; }
        public DbSet<Header> Headers { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
    }
}