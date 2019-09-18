

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
    }
}
