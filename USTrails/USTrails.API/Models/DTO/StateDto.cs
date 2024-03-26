namespace USTrails.API.Models.DTO
{
    public class StateDto
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string? StateImageUrl { get; set; }
    }
}
