using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnKey.Model.ViewModels;

namespace TurnKey.DAL.Interface
{
   public interface IEventsDAL
    {
        Task<List<Event>> GetAllEvents(Guid userId, string userRole, int Delear);

        Task<int> CreateEvents(Event events);
    }
}
