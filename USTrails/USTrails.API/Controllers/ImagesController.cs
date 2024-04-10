using AutoMapper;
using ByteSizeLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using USTrails.API.Models.DTO;
using USTrails.API.Repositories;

namespace USTrails.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImageRepository imageRepository;
        private readonly IMapper mapper;

        public ImagesController(IImageRepository imageRepository, IMapper mapper)
        {
            this.imageRepository = imageRepository;
            this.mapper = mapper;
        }

        [HttpPost("Upload")]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Upload([FromForm] CreateImageRequestDto createImageRequestDto)
        {
            ValidateImageUploadRequest(createImageRequestDto);

            if (ModelState.IsValid)
            {
                // Use request model to create image
                var image = await imageRepository.Upload(createImageRequestDto);

                // Return DTO
                return Ok(mapper.Map<ImageDto>(image));
            }

            return BadRequest(ModelState);
        }

        private void ValidateImageUploadRequest(CreateImageRequestDto createImageRequestDto)
        {
            var allowedExtensions = new string[] { ".jpg", ".jpeg", ".png" };
            if (!allowedExtensions.Contains(Path.GetExtension(createImageRequestDto.File.FileName)))
            {
                ModelState.AddModelError("file", "Unsupported file extension.");
            }

            const byte megaByteLimit = 4;
            if (createImageRequestDto.File.Length > ByteSize.BytesInMebiByte * megaByteLimit)
            {
                ModelState.AddModelError("file", "File size is more than 4MB.");
            }
        }
    }
}
