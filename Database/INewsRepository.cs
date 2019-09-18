using DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Database
{
    public interface INewsRepository
    {
        Task<IEnumerable<News>> GetLatestNews(int newsAmount);
        Task<IEnumerable<News>> GetAllNews();

    }
}
