using Alphastellar_WebAPI_Project.Infrastructure.Repositories.Interface;
using Alphastellar_WebAPI_Project.Models.DTOs;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Alphastellar_WebAPI_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CarController(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// This function gets all the cars for given colour.
        /// </summary>
        /// <param name="colour"></param>
        [HttpGet("Colour")]
        public async Task<IActionResult> GetCarsByColour(string colour)
        {
            var cars = await _carRepository.GetCarByColour(colour);

            if (cars == null)
            {
                return NotFound();
            }
            else
                return Ok(cars);
        }

        /// <summary>
        /// This function changes the headlights of the car with chosen Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Function returns the result of the request.</returns>
        [HttpPost("Id")]     
        public async Task<IActionResult> ChangeHeadlights(int id)
        {
            var model = await _carRepository.GetCarByID(id);

            var car = _mapper.Map<UpdateCarDTO>(model);

            if (car.Headlights == "Off")
            {
                car.Headlights = "On";
            }
            else
            {
                car.Headlights = "Off";
            }
            _carRepository.Update(car);
            return Ok();
        }

        #region NOT:
        //Car sınıfının headlights property'sinde değişiklik yapabilmek için ilk olarak HttpPatch kullanmam gerektiğini düşündüğüm için bu şekilde yazdım. Ancak sonradan yukarıdaki Post methodu ile değiştirdim.


        //[HttpPatch]
        //public async Task<IActionResult> UpdateCategory([FromBody] UpdateCarDTO model)
        //{
        //    if (!await _carRepository.Update(model))
        //    {
        //        ModelState.AddModelError(string.Empty, $"Something went wrong editing record {model.Id}");
        //        return StatusCode(500, ModelState);
        //    }
        //    return Ok();
        //}
        #endregion

        /// <summary>
        /// This function deletes the car with chosen Id.
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("Id")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            if (!await _carRepository.Delete(id))
            {
                ModelState.AddModelError(string.Empty, $"Something went wrong deleting record");
                return StatusCode(500, ModelState);
            }
            return Ok();
        }
    }
}
