using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LektionsovningCodeFirst
{
    public class EmployeeContext : DbContext
    {

        public EmployeeContext() : base("EmployeeDb")
        {
            Database.SetInitializer<EmployeeContext>(new EmployeeInitializer());
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Sallery> Salleries { get; set; }


        public class EmployeeInitializer : DropCreateDatabaseAlways<EmployeeContext>
        {
            protected override void Seed(EmployeeContext context)
            {
                var employees = new List<Employee>()
                {
                    new Employee()
                    {
                        EmployeeId = 1,
                        Name = "Kristian",
                        Title = "VD",
                        Phone = 555 - 554
                    },
                    new Employee()
                    {
                        EmployeeId = 2,
                        Name = "Patryk",
                        Title = "Vice VD",
                        Phone = 555 - 553
                    }
                };
                foreach (var employee in employees)
                {
                    context.Employees.Add(employee);
                }
                context.SaveChanges();

                var salleries = new List<Sallery>()
                {
                    new Sallery()
                    {
                        SalleryId = 1,
                        Date = new DateTime(2015,01,01),
                        WorkedHours = 170,
                        HoursOfPeriod = 2500,
                        MoneyOut = 34000

                    },
                    new Sallery()
                    {
                        SalleryId = 2,
                        Date = new DateTime(2015,03,01),
                        WorkedHours = 162,
                        HoursOfPeriod = 250,
                        MoneyOut = 32000

                    }
                };
                foreach (var sallery in salleries)
                {
                    context.Salleries.Add(sallery);
                }
                context.SaveChanges();
            }
        }
    }
}