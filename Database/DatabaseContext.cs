using DTO;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Database
{
  public  class DatabaseContext : IdentityDbContext<ApplicationUser>
    {
        public DatabaseContext() : base("DatabaseContext2", throwIfV1Schema: false)
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public static DatabaseContext Create()
        {
            return new DatabaseContext();
        }
        public DbSet<News> News { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Ranking> Ranking { get; set; }

    }
}
