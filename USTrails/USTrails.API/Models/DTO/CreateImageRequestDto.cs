using System.ComponentModel.DataAnnotations;

namespace USTrails.API.Models.DTO
{
    public class CreateImageRequestDto
    {
        [Required]
        public IFormFile File { get; set; }
        [Required]
        public string FileName { get; set; }
        public string? FileDescription { get; set; }
    }
}
