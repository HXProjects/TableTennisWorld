

using DTO;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Database
{
   public static class DatabaseFactory
    {
        public static INewsRepository GetNewsRepository()
        {
            return new NewsRepository();
        }
        public static IEventsRepository GetEventsRepository()
        {
            return new EventsRepository();
        }
        public static IRankingRepository GetRankingRepository()
        {
            return new RankingRepository();
        }

        public static IApplicationUserManager GetUserManager()
        {
            var manager = new ApplicationUserManager(new UserStore<ApplicationUser>(new DatabaseContext()));
            return manager;

        }
    }
}
