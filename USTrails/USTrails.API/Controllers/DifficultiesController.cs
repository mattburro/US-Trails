using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using USTrails.API.Models.DTO;
using USTrails.API.Repositories;

namespace USTrails.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DifficultiesController : ControllerBase
    {
        private readonly IDifficultyRepository difficultyRepository;
        private readonly IMapper mapper;

        public DifficultiesController(IDifficultyRepository difficultyRepository, IMapper mapper)
        {
            this.difficultyRepository = difficultyRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Get difficulties from database
            var difficulties = await difficultyRepository.GetAllAsync();

            // Return DTOs
            return Ok(difficulties);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] short id)
        {
            // Get difficulty from database
            var difficulty = await difficultyRepository.GetByIdAsync(id);

            // No difficulty found
            if (difficulty == null)
            {
                return NotFound();
            }

            // Return DTO
            return Ok(mapper.Map<DifficultyDto>(difficulty));
        }
    }
}
