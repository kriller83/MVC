using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxWebbApplication.Models
{
    public class Car
    {
        public int PersonId { get; set; }  //kopplar till person
        public string Color { get; set; }
        public string Brand { get; set; }   
    }
}