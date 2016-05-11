using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forelasning2EntityKoppling
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public IList<Person> Persons { get; set; }

    }
}