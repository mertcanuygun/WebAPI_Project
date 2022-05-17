using Alphastellar_WebAPI_Project.Infrastructure.Repositories.Interface;
using Alphastellar_WebAPI_Project.Models.Entities;
using Alphastellar_WebAPI_Project.Models.VMs;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Alphastellar_WebAPI_Project.Infrastructure.Repositories.Concrete
{
    public class BusRepository : IBusRepository
    {
        private readonly AppDbContext _appDbContext;

        public BusRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<TResult>> GetBuses<TResult>(Expression<Func<Bus, TResult>> selector, Expression<Func<Bus, bool>> expression = null)
        {
            IQueryable<Bus> query = _appDbContext.Buses;

            if (expression != null)
            {
                query = query.Where(expression);
            }
            return await query.Select(selector).ToListAsync();
        }

        public Task<List<GetBusesVM>> GetBusesByColour(string colour)
        {
            var buses = GetBuses(
                selector: x => new GetBusesVM
                {
                    Id = x.Id,
                    Colour = x.Colour,
                },
                expression: x => x.Colour == colour);

            return buses;
        }
    }
}
