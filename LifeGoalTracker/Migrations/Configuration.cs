namespace LifeGoalTracker.Migrations
{
    using LifeGoalTracker.Models;
    using Microsoft.AspNet.Identity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LifeGoalTracker.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LifeGoalTracker.Models.ApplicationDbContext context)
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

            var hasher = new PasswordHasher();

            //var adminUserId = Guid.Parse("5354e5c6-ec9e-406b-85d7-9e48bdf8b4d1").ToString();
            var adminUserId = "5354e5c6-ec9e-406b-85d7-9e48bdf8b4d1";
            var adminUser = new ApplicationUser {
                Id = adminUserId,
                UserName = "bendando@hotmail.co.uk",
                Email = "bendando@hotmail.co.uk",
                SecurityStamp = Guid.NewGuid().ToString(),  // NB: Resets security token, clearing logins
                PasswordHash = hasher.HashPassword("Ffantasy8")
            };

            context.Users.AddOrUpdate(
                // NB: If you need to update the email, switch to user => user.Id to update existing user by id instead of email
                user => user.Email,
                adminUser
                // , user2, user3, ...
                );

            context.SaveChanges();
        }
    }
}
