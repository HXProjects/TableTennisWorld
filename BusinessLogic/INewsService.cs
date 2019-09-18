using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
   public interface INewsService
    {
        Task<IEnumerable<News>> GetLatestNews(int newsAmount = 3);
        Task<IEnumerable<News>> GetAllNews();

    }
}
