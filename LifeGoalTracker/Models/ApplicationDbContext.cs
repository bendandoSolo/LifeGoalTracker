using Microsoft.AspNet.Identity.EntityFramework;

namespace LifeGoalTracker.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public System.Data.Entity.DbSet<LifeGoalTracker.Controllers.Day> Days { get; set; }
        // NB: IdentityDbContext providers .Users and .Roles db sets.
    }
}