using System.Collections.Generic;
using DTO;
using System.Threading.Tasks;

namespace Database
{
    public interface IEventsRepository
    {
        Task<IEnumerable<Events>> GetAllEvents();
    }
}
