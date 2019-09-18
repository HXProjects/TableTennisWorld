using DTO;
using System.Data.Entity;

namespace Database
{
  public  class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DatabaseContext")
        {
            System.Data.Entity.Database.SetInitializer(new DBInitializer());
        }
        public DbSet<News> News { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Ranking> Ranking { get; set; }

    }
}
