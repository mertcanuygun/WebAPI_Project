using Alphastellar_WebAPI_Project.Infrastructure.Repositories.Interface;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alphastellar_WebAPI_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly IBusRepository _busRepository;

        public BusController(IBusRepository busRepository)
        {
            _busRepository = busRepository;
        }

        /// <summary>
        /// This function gets all the buses for given colour.
        /// </summary>
        /// <param name="colour"></param>
        [HttpGet("Colour")]
        public async Task<IActionResult> GetBusesByColour(string colour)
        {
            var buses = await _busRepository.GetBusesByColour(colour);

            if (buses == null)
            {
                return NotFound();
            }
            else
                return Ok(buses);
        }

    }
}
