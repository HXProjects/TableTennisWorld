using System.Collections.Generic;
using DTO;
using System.Threading.Tasks;

namespace Database
{
    public interface IRankingRepository
    {
        Task<IEnumerable<Ranking>> GetRanking();
       

    }
}
