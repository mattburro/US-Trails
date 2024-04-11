namespace USTrails.UI.Models
{
    public class CreateTrailViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInMi { get; set; }
        public short DifficultyId { get; set; }
        public List<short> StateIds { get; set; }
    }
}
