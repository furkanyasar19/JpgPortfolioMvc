using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fuurkanjpg.Models.Siniflar
{
    public class Fotolar
    {
        [Key]
        public int ID { get; set; }
        public string FotoUrl { get; set; }
        public string Baslik { get; set; }
    }
}