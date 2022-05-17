using Alphastellar_WebAPI_Project.Models.Entities;
using Alphastellar_WebAPI_Project.Models.VMs;
using System.Linq.Expressions;

namespace Alphastellar_WebAPI_Project.Infrastructure.Repositories.Interface
{
    public interface IBusRepository
    {
        Task<List<TResult>> GetBuses<TResult>(Expression<Func<Bus, TResult>> selector,
                                             Expression<Func<Bus, bool>> expression = null);
        Task<List<GetBusesVM>> GetBusesByColour(string colour);
    }
}
