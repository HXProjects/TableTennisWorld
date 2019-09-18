using System.Collections.Generic;
using System.Threading.Tasks;
using DTO;
using Database;
using System;


namespace BusinessLogic
{
    public class RankingService : IRankingService
    {
        private IRankingRepository _rankingRepository;
        public RankingService()
        {
            _rankingRepository = DatabaseFactory.GetRankingRepository();
        }
        public async Task<IEnumerable<Ranking>> GetRanking()
        {
            return await _rankingRepository.GetRanking();
        }
    }
}
