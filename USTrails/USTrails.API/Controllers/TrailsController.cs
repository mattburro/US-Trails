using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using USTrails.API.Models.Domain;
using USTrails.API.Models.DTO;
using USTrails.API.Repositories;

namespace USTrails.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrailsController : ControllerBase
    {
        private readonly ITrailRepository trailRepository;
        private readonly IMapper mapper;

        public TrailsController(ITrailRepository trailRepository, IMapper mapper)
        {
            this.trailRepository = trailRepository;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTrailRequestDto createRequestDto)
        {
            // Use request model to create trail
            var createdTrail = await trailRepository.CreateAsync(createRequestDto);

            // Return DTO
            return Ok(mapper.Map<TrailDto>(createdTrail));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string? filterOn, [FromQuery] string? filterValue)
        {
            // Get trails from database
            var trails = await trailRepository.GetAllAsync(filterOn, filterValue);

            // Return DTOs
            return Ok(mapper.Map<List<TrailDto>>(trails));
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            // Get trail from database
            var trail = await trailRepository.GetByIdAsync(id);

            // No trail found
            if (trail == null)
            {
                return NotFound();
            }

            // Return DTO
            return Ok(mapper.Map<TrailDto>(trail));
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, UpdateTrailRequestDto updateRequestDto)
        {
            // Use request model to update trail
            var updatedTrail = await trailRepository.UpdateAsync(id, updateRequestDto);

            // No trail found
            if (updatedTrail == null)
            {
                return NotFound();
            }

            // Return DTO
            return Ok(mapper.Map<TrailDto>(updatedTrail));
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            // Delete trail using id
            var deletedTrail = await trailRepository.DeleteAsync(id);

            // No trail found
            if (deletedTrail == null)
            {
                return NotFound();
            }

            // Return DTO
            return Ok(mapper.Map<TrailDto>(deletedTrail));
        }
    }
}
