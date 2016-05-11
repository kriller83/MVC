using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Forelasning2EntityKoppling
{
    public class PersonContext : DbContext
    {
        public PersonContext():base("Choklad") //Konstruktor
        {
            Database.SetInitializer<PersonContext>(new PersonInitializer());
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }


        public class PersonInitializer : DropCreateDatabaseAlways<PersonContext> //
        {
            protected override void Seed(PersonContext context)
            {
                var persons = new List<Person>()
                {
                    new Person()
                    {
                        PersonId = 1,
                        Name = "Freddie Wahlgren",
                        DateOfBirth = new DateTime(1997, 01, 03),
                        Height = 187.00M,
                        Weight = 85.34M
                    },
                    new Person()
                    {
                        PersonId = 2,
                        Name = "Kristian Ragnvaldsson",
                        DateOfBirth = new DateTime(1983, 06, 10),
                        Height = 187.00M,
                        Weight = 85.34M
                    }
                };

                foreach (var person in persons)
                {
                    context.Persons.Add(person);
                }
                context.SaveChanges();

                var addresses = new List<Address>()
                {
                    new Address()
                    {
                        AddressId = 1,
                        Street = "Kasten Rönnowsgatan 6",
                        City = "Halmstad",
                        Zip = "30294",
                    },

                    new Address()
                    {
                        AddressId = 2,
                        Street = "Torsgatan 4b",
                        City = "Halmstad",
                        Zip = "30290",
                    },
                    new Address()
                    {
                        AddressId = 3,
                        Street = "Brogatan 3",
                        City = "Halmstad",
                        Zip = "30274",
                    }
                };
                foreach (var address in addresses)
                {
                    context.Addresses.Add(address);
                }
                context.SaveChanges();
            }
        }
       
    }
}