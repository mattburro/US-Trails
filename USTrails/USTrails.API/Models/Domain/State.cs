namespace USTrails.API.Models.Domain
{
    public class State
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string? StateImageUrl { get; set; }
    }
}
