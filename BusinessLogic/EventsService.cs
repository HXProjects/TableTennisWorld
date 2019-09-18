using System.Collections.Generic;
using System.Threading.Tasks;
using DTO;
using Database;
using System;

namespace BusinessLogic
{
    public class EventsService : IEventsService
    {
        private IEventsRepository _eventsRepository;
        public EventsService()
        {
            _eventsRepository = DatabaseFactory.GetEventsRepository();
        }
        public async Task<IEnumerable<Events>> GetAllEvents()
        {
            return await _eventsRepository.GetAllEvents();
        }
    }
}
