using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forelasning1.Models
{
    public class KungFuMasterModel
    {
        public int ID { get; set; }  //Primary key (int ID)
        public string  Name { get; set; }
        public int Age { get; set; }
        public string KungFuStyle { get; set; }
        public string Level { get; set; }
    }
}