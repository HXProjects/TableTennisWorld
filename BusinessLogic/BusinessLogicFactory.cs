

namespace BusinessLogic
{
   public static class BusinessLogicFactory
    {
        public static INewsService GetNewsService()
        {
            return new NewsService();
        }
        public static IEventsService GetEventsService()
        {
            return new EventsService();
        }
        public static IRankingService GetRankingService()
        {
            return new RankingService();
        }
    }
}
