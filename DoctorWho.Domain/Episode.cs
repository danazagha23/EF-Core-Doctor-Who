﻿namespace DoctorWho.Domain
{
    public class Episode
    {
        public Episode()
        {
            this.EpisodeCompanions = new List<EpisodeCompanion>();
            this.EpisodeEnemies = new List<EpisodeEnemy>();
        }
        public int EpisodeId { get; set; }
        public int? SeriesNumber { get; set; }
        public int? EpisodeNumber { get; set; }
        public string EpisodeType { get; set; }
        public string Title { get; set; }
        public DateTime? EpisodeDate { get; set; }
        public int AuthorId { get; set; }
        public int DoctorId { get; set; }
        public string Notes { get; set; }
        public List<EpisodeCompanion> EpisodeCompanions { get; set; }
        public List<EpisodeEnemy> EpisodeEnemies { get; set; }
    }
}