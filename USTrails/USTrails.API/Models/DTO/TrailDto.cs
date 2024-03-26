namespace USTrails.API.Models.DTO
{
    public class TrailDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInMi { get; set; }
        public string? TrailImageUrl { get; set; }
        public DifficultyDto Difficulty { get; set; }
        public StateDto State { get; set; }
    }
}
