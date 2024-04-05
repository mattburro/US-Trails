using System.ComponentModel.DataAnnotations.Schema;

namespace USTrails.API.Models.Domain
{
    public class Trail
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInMi { get; set; }
        public string? TrailImageUrl { get; set; }

        #region Navigation Properties
        public byte DifficultyId { get; set; }
        public Difficulty Difficulty { get; set; }
        [ForeignKey(nameof(States))]
        public ICollection<byte> StateIds { get; set; } = new List<byte>();
        public ICollection<State> States { get; set; } = new List<State>();
        #endregion
    }
}
