using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LektionsovningCodeFirst
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int Phone { get; set; }
        public IList<Sallery> Salleries { get; set; }
    }
}