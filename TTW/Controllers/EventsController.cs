using System.Web.Mvc;
using BusinessLogic;
using System.Threading.Tasks;
using TTW.Models;
using System.Collections.Generic;

namespace TTW.Controllers
{
    public class EventsController : Controller
    {
        private readonly IEventsService _eventsService;

        public EventsController()
        {
            _eventsService = BusinessLogicFactory.GetEventsService();
        }
        
        public async Task<ActionResult> GetAllEvents()
        {
            var events = await _eventsService.GetAllEvents();
            List<Events> eventsCollection = new List<Events>();
            foreach (var item in events)
            {
                Events eventItem = new Events
                {
                    Id = item.Id,
                    Name = item.Name,
                    Dates = item.Dates,
                    Link = item.Link,
                    Type = item.Type
                    
                };
                eventsCollection.Add(eventItem);
            }
            return View(eventsCollection);
        }
        public async Task<JsonResult> GetJsonAllEvents()
        {
            var events = await _eventsService.GetAllEvents();
            List<Events> eventsCollection = new List<Events>();
            foreach (var item in events)
            {
                Events eventItem = new Events
                {
                    Id = item.Id,
                    Name = item.Name,
                    Dates = item.Dates,
                    Type = item.Type,
                    Link = item.Link
                };
                eventsCollection.Add(eventItem);
            }
            return Json(eventsCollection, JsonRequestBehavior.AllowGet);

        }
    }
}