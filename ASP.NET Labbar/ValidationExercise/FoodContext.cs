using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ValidationExercise
{
    public class FoodContext : DbContext
    {
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Cake> Cakes { get; set; }

        public FoodContext():base("FoodDatabase2")
        {
            
        }
    }
}   