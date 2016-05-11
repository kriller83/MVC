﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoBooks_Labb3_Uppgift1.Models
{
    public class Book
    {
        [ScaffoldColumn(false)]
        public int BookID { get; set; }
        [Required]
        public string Title { get; set; }
        [Range(1, 500)]
        public decimal Price { get; set; }
        public string Genre  { get; set; }      
        [ScaffoldColumn(false)]
        public int AuthorID { get; set; }
        public virtual Author Author { get; set; }
    }
}
