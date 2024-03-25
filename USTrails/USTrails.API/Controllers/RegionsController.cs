using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using USTrails.API.Models.Domain;
using USTrails.API.Models.DTO;
using USTrails.API.Repositories;

namespace USTrails.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Get regions from database
            var regions = await regionRepository.GetAllAsync();

            // Return DTOs
            return Ok(mapper.Map<List<RegionDto>>(regions));
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            // Get matching region from database
            var region = await regionRepository.GetByIdAsync(id);

            // Check if region is null
            if (region == null)
            {
                return NotFound();
            }

            // Return DTO
            return Ok(mapper.Map<RegionDto>(region));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddRegionRequestDto requestDto)
        {
            // Map DTO to domain model
            var region = mapper.Map<Region>(requestDto);

            // Use domain model to create region
            region = await regionRepository.CreateAsync(region);

            // Return DTO
            return CreatedAtAction(nameof(GetById), new { id = region.Id }, mapper.Map<RegionDto>(region));
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateRegionRequestDto requestDto)
        {
            // Map DTO to domain model
            var region = mapper.Map<Region>(requestDto);

            // Use domain model to update region
            region = await regionRepository.UpdateAsync(id, region);

            // Check if region is null
            if (region == null)
            {
                return NotFound();
            }

            // Return DTO
            return Ok(mapper.Map<RegionDto>(region));
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            // Try to delete region
            var region = await regionRepository.DeleteAsync(id);

            // Check if region is null
            if (region == null)
            {
                return NotFound();
            }

            // Return DTO
            return Ok(mapper.Map<RegionDto>(region));
        }
    }
}
