using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxWebbApplication.Models
{
    public class Rabbit
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AngerLevel { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Grudge> Grudges { get; set; }  //Skapar en ny class som heter Grudge!! 
    }
}