using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Labb4_uppg2.Models
{
        public class Student
        {
            public int StudentId { get; set; }
            [DisplayName("Förnamn")]
            public string FirstName { get; set; }
            [DisplayName("Efternamn")]
            public string LastName { get; set; }
            [DisplayName("Personnummer")]
            public string SocialSecuretyNumber { get; set; }
            [DisplayName("Adress")]
            public string Address { get; set; }
            [DisplayName("Betyg")]
            public List<Grade> Grades { get; set; } = new List<Grade>();
        
    }
}