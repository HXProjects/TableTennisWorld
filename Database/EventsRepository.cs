using DTO;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Database
{
    public class EventsRepository : IEventsRepository
    {        public EventsRepository()
        {
        }
        public async Task<IEnumerable<Events>> GetAllEvents()
        {
            var result = new List<Events>();
            using (var databaseContext = new DatabaseContext())
            {
                result = await databaseContext.Events.OrderBy(x => x.Id).ToListAsync();
            }
            return result;
        }

    }
}
