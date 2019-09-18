using System.Web.Mvc;
using BusinessLogic;
using System.Threading.Tasks;
using TTW.Models;
using System.Collections.Generic;

namespace TTW.Controllers
{
    public class NewsController : Controller
    {
         private readonly INewsService _newsService;
         public NewsController()
         {
             _newsService = BusinessLogicFactory.GetNewsService();
         }
        
         public async Task<ActionResult> GetAllNews()
         {
             var news = await _newsService.GetAllNews();
            List<News> newsCollection = new List<News>();
            foreach (var item in news)
            {
                News newsItem = new News
                {
                    Id = item.Id,
                    Title = item.Title,
                    Date = item.Date.ToString("yyyy-MM-dd"),
                    Content = item.Content,
                    ImageLink = item.ImageLink
                };
                newsCollection.Add(newsItem);
            }
            return View(newsCollection);
         }
         
        
        public async Task<JsonResult> GetNews()
        {
            const int NewsAmount = 3;
            var news = await _newsService.GetLatestNews(NewsAmount);
            List<News> newsCollection = new List<News>();
            foreach (var item in news)
            {
                News newsItem = new News
                {
                    Id = item.Id,
                    Title = item.Title,
                    Date = item.Date.ToString("yyyy-MM-dd"),
                    Content = item.Content,
                    ImageLink = item.ImageLink 
                };
                newsCollection.Add(newsItem);
            }
            return Json(newsCollection, JsonRequestBehavior.AllowGet);
           
        }
        public async Task<JsonResult> GetJsonAllNews()
        {
            var news = await _newsService.GetAllNews();
            List<News> newsCollection = new List<News>();
            foreach (var item in news)
            {
                News newsItem = new News
                {
                    Id = item.Id,
                    Title = item.Title,
                    Date = item.Date.ToString("yyyy-MM-dd"),
                    Content = item.Content,
                    ImageLink = item.ImageLink
                };
                newsCollection.Add(newsItem);
            }
            return Json(newsCollection, JsonRequestBehavior.AllowGet);

        }

    }
}