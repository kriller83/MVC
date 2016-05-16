using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ValidationExercise.Attributes;

namespace ValidationExercise
{
    public class Cake
    {
        [Required]
        public int CakeId { get; set; }

        [Required, MaxLength(100), FilthyCheck]
        public string Name { get; set; }

        [Required, MaxLength(4000), FilthyCheck]
        public string Ingredients { get; set; }

        [Required, MaxLength(4000), FilthyCheck]
        public string Instructions { get; set; }

        [Required, Range(1,180)]
        public int CookingTime { get; set; }

        public virtual List<Review> Reviews { get; set; }  
    }
}