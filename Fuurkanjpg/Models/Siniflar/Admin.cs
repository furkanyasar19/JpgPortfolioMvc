using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fuurkanjpg.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAd { get; set; }
        public string Parola { get; set; }
    }
}