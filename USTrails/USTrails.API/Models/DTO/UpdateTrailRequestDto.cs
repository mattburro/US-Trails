using System.ComponentModel.DataAnnotations;

namespace USTrails.API.Models.DTO
{
    public class UpdateTrailRequestDto
    {
        [MaxLength(255)]
        public string? Name { get; set; }

        [MaxLength(4095)]
        public string? Description { get; set; }

        public double? LengthInMi { get; set; }

        public string? TrailImageUrl { get; set; }

        public Guid? DifficultyId { get; set; }

        public List<Guid>? StateIds { get; set; }
    }
}
