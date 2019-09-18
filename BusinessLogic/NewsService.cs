using System.Collections.Generic;
using System.Threading.Tasks;
using DTO;
using Database;

namespace BusinessLogic
{
    class NewsService : INewsService
    {
        private INewsRepository _newsRepository;

        public NewsService()
        {
            _newsRepository = DatabaseFactory.GetNewsRepository();
        }
        public async Task<IEnumerable<News>> GetLatestNews(int newsAmount = 3)
        {
            return  await _newsRepository.GetLatestNews(newsAmount);
        }

        public async Task<IEnumerable<News>> GetAllNews()
        {
            return await _newsRepository.GetAllNews();
        }
    }
}
