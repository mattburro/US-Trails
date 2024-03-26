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

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
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

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddStateRequestDto requestDto)
        {
            // Map DTO to domain model
            var state = mapper.Map<State>(requestDto);

            // Use domain model to create state
            state = await stateRepository.CreateAsync(state);

            // Return DTO
            return CreatedAtAction(nameof(GetById), new { id = state.Id }, mapper.Map<StateDto>(state));
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateStateRequestDto requestDto)
        {
            // Map DTO to domain model
            var state = mapper.Map<State>(requestDto);

            // Use domain model to update state
            state = await stateRepository.UpdateAsync(id, state);

            // Check if state is null
            if (state == null)
            {
                return NotFound();
            }

            // Return DTO
            return Ok(mapper.Map<StateDto>(state));
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            // Try to delete state
            var state = await stateRepository.DeleteAsync(id);

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
