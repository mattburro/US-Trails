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
        public async Task<IActionResult> Create([FromBody] AddTrailRequestDto requestDto)
        {
            // Map DTO to domain model
            var trail = mapper.Map<Trail>(requestDto);

            // Use domain model to create trail
            trail = await trailRepository.CreateAsync(trail);

            // Return DTO
            return Ok(mapper.Map<TrailDto>(trail));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Get trails from database
            var trails = await trailRepository.GetAllAsync();

            // Return DTOs
            return Ok(mapper.Map<List<TrailDto>>(trails));
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetById(Guid id)
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
    }
}
