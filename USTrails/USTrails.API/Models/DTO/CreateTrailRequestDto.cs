using System.ComponentModel.DataAnnotations;

namespace USTrails.API.Models.DTO
{
    public class CreateTrailRequestDto
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(4095)]
        public string Description { get; set; }

        [Required]
        public double LengthInMi { get; set; }

        public string? TrailImageUrl { get; set; }

        [Required]
        public short DifficultyId { get; set; }

        [Required]
        public List<short> StateIds { get; set; }
    }
}
