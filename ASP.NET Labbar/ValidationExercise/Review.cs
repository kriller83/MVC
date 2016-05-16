using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ValidationExercise.Attributes;

namespace ValidationExercise
{
    public class Review
    {
        [Required]
        public int ReviewId { get; set; }

        [Required, FilthyCheck]
        public string Title { get; set; }  

        [Required, MaxLength(1000), FilthyCheck] 
        public string Summary { get; set; }

        [Required, Range(0,10) ]
        public int Score { get; set; }

        [Required]
        public int CakeId { get; set; } 
        public Cake Cake { get; set; }
    }


}