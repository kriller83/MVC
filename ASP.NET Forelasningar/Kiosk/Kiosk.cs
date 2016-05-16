using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Forelasning2EntityKoppling;

namespace Kiosk
{
    public class Kiosk
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public ICollection<Review> Review { get; set; }
    }
}