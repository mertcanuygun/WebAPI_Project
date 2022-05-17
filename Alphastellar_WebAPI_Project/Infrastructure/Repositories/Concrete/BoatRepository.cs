using Alphastellar_WebAPI_Project.Infrastructure.Repositories.Interface;
using Alphastellar_WebAPI_Project.Models.Entities;
using Alphastellar_WebAPI_Project.Models.VMs;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Alphastellar_WebAPI_Project.Infrastructure.Repositories.Concrete
{
    public class BoatRepository:IBoatRepository
    {
        private readonly AppDbContext _appDbContext;

        public BoatRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<TResult>> GetBoats<TResult>(Expression<Func<Boat, TResult>> selector, Expression<Func<Boat, bool>> expression = null)
        {
            IQueryable<Boat> query = _appDbContext.Boats;

            if (expression != null)
            {
                query = query.Where(expression);
            }
            return await query.Select(selector).ToListAsync();
        }

        public Task<List<GetBoatsVM>> GetBoatsByColour(string colour)
        {
            var boats = GetBoats(
                selector: x => new GetBoatsVM
                {
                    Id = x.Id,
                    Colour = x.Colour,
                },
                expression: x => x.Colour == colour);

            return boats;
        }
    }
}
