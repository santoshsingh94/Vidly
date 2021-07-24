namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Vidly.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Vidly.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Vidly.Models.ApplicationDbContext context)
        {
           
            //context.MembershipTypes.AddOrUpdate(
            //    new MembershipType() { Id = 1, SignUpFee = 0, DurationInMonths = 0, DiscountRate = 0, Name = "Pay as You Go" },
            //    new MembershipType() { Id = 2, SignUpFee = 30, DurationInMonths = 1, DiscountRate = 10, Name = "Monthly"},
            //    new MembershipType() { Id = 3, SignUpFee = 90, DurationInMonths = 3, DiscountRate = 15, Name = "Quarterly" },
            //    new MembershipType() { Id = 4, SignUpFee = 300, DurationInMonths = 12, DiscountRate = 20, Name = "Annual" }
            //    );
            //context.Customers.AddOrUpdate(
            //    new Customer() { Id = 1, Name = "John Smith" , IsSubscribedToNewsletter = false, MembershipTypeId = 1},                
            //    new Customer() { Id = 2, Name = "Marry Williams" , IsSubscribedToNewsletter = true, MembershipTypeId = 2}                
            //    );
        }
    }
}
