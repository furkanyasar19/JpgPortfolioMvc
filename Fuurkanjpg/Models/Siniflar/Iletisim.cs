using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fuurkanjpg.Models.Siniflar
{
    public class Iletisim
    {
        [Key]
        public int ID { get; set; }
        public string Isim { get; set; }
        public string Konu { get; set; }
        public string Email { get; set; }
        public string Numara { get; set; }
        public string Mesaj { get; set; }
    }
}