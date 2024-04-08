using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using USTrails.API.Models.Domain;
using USTrails.API.Models.DTO;
using USTrails.API.Repositories;

namespace USTrails.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        private readonly IStateRepository stateRepository;
        private readonly IMapper mapper;

        public StatesController(IStateRepository stateRepository, IMapper mapper)
        {
            this.stateRepository = stateRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Get states from database
            var states = await stateRepository.GetAllAsync();

            // Return DTOs
            return Ok(mapper.Map<List<StateDto>>(states));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] short id)
        {
            // Get matching state from database
            var state = await stateRepository.GetByIdAsync(id);

            // Check if state is null
            if (state == null)
            {
                return NotFound();
            }

            // Return DTO
            return Ok(mapper.Map<StateDto>(state));
        }
    }
}
