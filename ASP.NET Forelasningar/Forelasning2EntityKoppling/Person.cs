using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forelasning2EntityKoppling
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; } //nullable
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public Address Address { get; set; }    
    }
}