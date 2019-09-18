using DTO;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Database
{
    public class RankingRepository : IRankingRepository
    {
        public RankingRepository()
        {
        }
        public async Task<IEnumerable<Ranking>> GetRanking()
        {
            var result = new List<Ranking>();
            using (var databaseContext = new DatabaseContext())
            {
                result = await databaseContext.Ranking.OrderBy(x => x.Id).ToListAsync();
            }
            return result;
        }

    }
}
