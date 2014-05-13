using System.Collections.Generic;

namespace UltimateTeam.Toolkit.Models
{
    public class LeaderboardResponse
    {
        public ClubInfo clubInfo { get; set; }

        public List<Category> category { get; set; }
    }

    public class ClubInfo
    {
        public uint credits { get; set; }
        public uint trophies { get; set; }
        public uint won { get; set; }
        public uint draw { get; set; }
        public uint loss { get; set; }
    }


    public class Category
    {
        public string id { get; set; }
        public Score score { get; set; }
        public Tiebreak tiebreak { get; set; }

    }

    public class Score
    {
        public uint value { get; set; }
    }

    public class Tiebreak
    {
        public uint value { get; set; }
    }
}
