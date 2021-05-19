using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppliCodeFirst.Models
{
    public class Voiture
    {
        public Int32 id { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public string NChassis { get; set; }
    }
}