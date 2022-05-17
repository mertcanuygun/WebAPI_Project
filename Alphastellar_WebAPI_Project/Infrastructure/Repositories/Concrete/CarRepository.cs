using Alphastellar_WebAPI_Project.Infrastructure.Repositories.Interface;
using Alphastellar_WebAPI_Project.Models.DTOs;
using Alphastellar_WebAPI_Project.Models.Entities;
using Alphastellar_WebAPI_Project.Models.VMs;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Alphastellar_WebAPI_Project.Infrastructure.Repositories.Concrete
{
    public class CarRepository:ICarRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public CarRepository(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            var category = await _appDbContext.Cars.FindAsync(id);

            category.Status = Status.Passive;

            return await Save();
        }

        public async Task<TResult> GetCar<TResult>(Expression<Func<Car, TResult>> selector, Expression<Func<Car, bool>> expression = null)
        {
            IQueryable<Car> query = _appDbContext.Cars;

            if (expression != null)
            {
                query = query.Where(expression);
            }
            return await query.Select(selector).FirstOrDefaultAsync();
        }

        public Task<List<GetCarsVM>> GetCarByColour(string colour)
        {
            var cars = GetCars(
                selector: x => new GetCarsVM
                {
                    Id = x.Id,
                    Colour = x.Colour,
                    Headlights = x.Headlights,
                },
                expression: x => x.Colour == colour);

            return cars;
        }

        public Task<GetCarsVM> GetCarByID(int id)
        {
            var car = GetCar(
                selector: x => new GetCarsVM
                {
                    Id = x.Id,
                    Colour = x.Colour,
                    Headlights = x.Headlights,
                },
                expression: x => x.Id == id);

            return car;
        }

        public async Task<List<TResult>> GetCars<TResult>(Expression<Func<Car, TResult>> selector, Expression<Func<Car, bool>> expression = null)
        {
            IQueryable<Car> query = _appDbContext.Cars;

            if (expression != null)
            {
                query = query.Where(expression);
            }
            return await query.Select(selector).ToListAsync();
        }

        public async Task<bool> Save()
        {
            return await _appDbContext.SaveChangesAsync() > 0 ? true : false;
        }

        public async Task<bool> Update(UpdateCarDTO model)
        {
            var car = _mapper.Map<Car>(model);

            _appDbContext.Cars.Update(car); 

            return await Save();
        }
    }
}
