using System;
using System.ComponentModel.DataAnnotations;

namespace Kiosk
{
    public class Review
    {   //Virtual = mappa mot entity framework (blir enklare) 
        public virtual int ID { get; set; }
        public virtual Kiosk Kiosk { get; set; }
        [Range(1,10)]
        public virtual int Rating { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public virtual string Body { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public virtual DateTime ReviewDate { get; set; }

        //public void temp()    (fuskmetod som skapar unit tests)
    }
}