﻿namespace USTrails.API.Models.Domain
{
    public class Trail
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInMi { get; set; }
        public string? TrailImageUrl { get; set; }
        public Guid DifficultyId { get; set; }
        public Guid StateId { get; set; }

        #region Navigation Properties

        public Difficulty Difficulty { get; set; }
        public State State { get; set; }

        #endregion
    }
}
