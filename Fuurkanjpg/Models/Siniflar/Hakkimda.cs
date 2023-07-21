using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fuurkanjpg.Models.Siniflar
{
    public class Hakkimda
    {
        [Key]
        public int ID { get; set; }
        public string HakkimdaYazi { get; set; }
        public string HakkimdaFoto { get; set; }
    }
}