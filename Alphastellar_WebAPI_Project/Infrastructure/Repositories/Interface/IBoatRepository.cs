using Alphastellar_WebAPI_Project.Models.Entities;
using Alphastellar_WebAPI_Project.Models.VMs;
using System.Linq.Expressions;

namespace Alphastellar_WebAPI_Project.Infrastructure.Repositories.Interface
{
    public interface IBoatRepository
    {
        Task<List<TResult>> GetBoats<TResult>(Expression<Func<Boat, TResult>> selector,
                                             Expression<Func<Boat, bool>> expression = null);
        Task<List<GetBoatsVM>> GetBoatsByColour(string colour);
    }
}
