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
        [ForeignKey(nameof(Difficulty))]
        public short DifficultyId { get; set; }
        [ForeignKey(nameof(States))]
        public IList<short> StateIds { get; set; } = new List<short>();

        #region Navigation Properties
        public Difficulty Difficulty { get; set; }
        public IList<State> States { get; set; } = new List<State>();
        #endregion
    }
}
