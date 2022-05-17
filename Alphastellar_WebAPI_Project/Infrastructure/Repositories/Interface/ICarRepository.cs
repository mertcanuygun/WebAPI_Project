using Alphastellar_WebAPI_Project.Models.DTOs;
using Alphastellar_WebAPI_Project.Models.Entities;
using Alphastellar_WebAPI_Project.Models.VMs;
using System.Linq.Expressions;

namespace Alphastellar_WebAPI_Project.Infrastructure.Repositories.Interface
{
    public interface ICarRepository
    {
        Task<GetCarsVM> GetCarByID(int id);
        Task<TResult> GetCar<TResult>(Expression<Func<Car, TResult>> selector,
                                    Expression<Func<Car, bool>> expression = null);

        Task<List<TResult>> GetCars<TResult>(Expression<Func<Car, TResult>> selector,
                                             Expression<Func<Car, bool>> expression = null);
        Task<List<GetCarsVM>> GetCarByColour(string colour);
        Task<bool> Update(UpdateCarDTO model);
        Task<bool> Save();
        Task<bool> Delete(int id);
        
    }
}
