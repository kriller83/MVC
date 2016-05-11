using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forelasning1.Models
{
    public class BeerDetailsModel
    {  
        //propfull
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal AlcoholVolume { get; set; }
    }
}