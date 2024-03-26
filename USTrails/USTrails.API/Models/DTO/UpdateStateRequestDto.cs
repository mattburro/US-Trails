namespace USTrails.API.Models.DTO
{
    public class UpdateStateRequestDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string? StateImageUrl { get; set; }
    }
}
