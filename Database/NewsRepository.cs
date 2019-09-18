using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.Entity;

namespace Database
{
   public class NewsRepository : INewsRepository
    {
        public NewsRepository()
        {           
        }


        public async Task<IEnumerable<News>> GetLatestNews(int newsAmount)
        {
            var result = new List<News>();
            using (var databaseContext = new DatabaseContext())
            {
                result = await databaseContext.News.OrderBy(x => x.Id).Take(newsAmount).ToListAsync();
            }
            return result;
                
        }
        public async Task<IEnumerable<News>> GetAllNews()
        {
            var result = new List<News>();
            using (var databaseContext = new DatabaseContext())
            {
                result = await databaseContext.News.OrderBy(x => x.Date).ToListAsync();
            }
            return result;
        }

    }
}
