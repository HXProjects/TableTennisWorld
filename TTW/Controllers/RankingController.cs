using System.Web.Mvc;
using BusinessLogic;
using System.Threading.Tasks;
using TTW.Models;
using System.Collections.Generic;

namespace TTW.Controllers
{
    public class RankingController : Controller
    {
        private readonly IRankingService _rankingService;

        public RankingController()
        {
            _rankingService = BusinessLogicFactory.GetRankingService();
        }

        public async Task<ActionResult> GetRanking()
        {
            var ranking = await _rankingService.GetRanking();
            List<Ranking> rankingCollection = new List<Ranking>();
            foreach (var item in ranking)
            {
                Ranking player = new Ranking
                {
                    Id = item.Id,
                    Position = item.Position,
                    PrevPosition = item.PrevPosition,
                    Points = item.Points,
                    Player = item.Player,
                    Country = item.Country,
                    Gender = item.Gender,
                    CountryAlfaCode = item.CountryAlfaCode,
                    Continent = item.Continent


                };
                rankingCollection.Add(player);
            }
            return View(rankingCollection);
        }
        public async Task<JsonResult> GetJsonRanking()
        {
            var ranking = await _rankingService.GetRanking();
            List<Ranking> rankingCollection = new List<Ranking>();
            foreach (var item in ranking)
            {
                Ranking player = new Ranking
                {
                    Id = item.Id,
                    Position = item.Position,
                    PrevPosition = item.PrevPosition,
                    Points = item.Points,
                    Player = item.Player,
                    Country = item.Country,
                    Gender = item.Gender,
                    CountryAlfaCode = item.CountryAlfaCode,
                    Continent = item.Continent

                };
                rankingCollection.Add(player);
            }
            return Json(rankingCollection, JsonRequestBehavior.AllowGet);

        }
    }
}