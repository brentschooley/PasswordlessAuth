namespace PasswordlessAuth.Migrations
{
    using PasswordlessAuth.Models;
    using System;
    using System.Configuration;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PasswordlessAuth.Models.UserContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PasswordlessAuth.Models.UserContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Users.AddOrUpdate(
                new User
                {
                    Email = ConfigurationManager.AppSettings["YourEmailAddress"],
                    PhoneNumber = ConfigurationManager.AppSettings["YourCellphoneNumber"]
                }
            );
            context.SaveChanges();
        }
    }
}
