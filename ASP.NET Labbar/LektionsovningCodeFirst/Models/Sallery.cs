using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LektionsovningCodeFirst
{
    public class Sallery
    {
        public int SalleryId { get; set; }
        public DateTime Date { get; set; }
        public int WorkedHours { get; set; }
        public int HoursOfPeriod { get; set; }
        public int MoneyOut { get; set; }
        public Employee Employees { get; set; }
    }
}