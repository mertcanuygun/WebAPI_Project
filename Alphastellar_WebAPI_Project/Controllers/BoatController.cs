using Alphastellar_WebAPI_Project.Infrastructure.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alphastellar_WebAPI_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        private readonly IBoatRepository _boatRepository;

        public BoatController(IBoatRepository boatRepository)
        {
            _boatRepository = boatRepository;
        }

        /// <summary>
        /// This function gets all the boats for given colour.
        /// </summary>
        /// <param name="colour"></param>
        [HttpGet("Colour")]
        public async Task<IActionResult> GetBoatsByColour(string colour)
        {
            var boats = await _boatRepository.GetBoatsByColour(colour);

            if (boats == null)
            {
                return NotFound();
            }
            else
                return Ok(boats);
        }
    }
}
