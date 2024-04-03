namespace USTrails.API.Models.DTO
{
    public class UpdateTrailRequestDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInMi { get; set; }
        public string? TrailImageUrl { get; set; }
        public Guid DifficultyId { get; set; }
        public List<Guid> StateIds { get; set; }
    }
}
