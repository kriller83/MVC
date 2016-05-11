using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forelasning1.Models
{
    //Detta är vår modell!!
    public class RecipeDetailsModel //klasserna ska vara publica i Models. Vi har skapat en klass med properties. ctr + rr = byt namn
    {
        public string Name { get; set; }  
        public string Ingredients { get; set; }
        public int CookingTime { get; set; }
        public string Instructions { get; set; }
        public int Difficulty { get; set; }
    }
}