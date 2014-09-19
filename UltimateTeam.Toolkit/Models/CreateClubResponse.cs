using System.Collections.Generic;

namespace UltimateTeam.Toolkit.Models
{
    public class CreateClubResponse
    {
        public string bonusPacks;
        public ResLogin login;
        public UserData userData;
        public List<ItemData> starterPack { get; set; }
    }

    public class ResLogin
    {
        public string clubAbbr { get; set; }
        public string clubName { get; set; }
        public List<ItemData> actives { get; set; }
        
        public BidTokens bidTokens { get; set; }
        public uint credits { get; set; }
        public uint draw { get; set; }
        public long established { get; set; }
        public uint loss { get; set; }
        public long personaId { get; set; }
        public bool purchased { get; set; }
        public Reliability reliability { get; set; }
        public bool seasonTicket { get; set; }
        public uint trophies { get; set; }
        public UnopenedPacks unopenedPacks { get; set; }
        public uint won { get; set; }

    }
    public class Reliability
    {
        public uint finishedMatches;
        public uint matchUnfinishedTime;
        public uint reliability;
        public uint startedMatches;
    }
    public class UserData
    {
        public int accountResetCount = 0;
        public int onlineELORating = 1200;
        public bool onlineRatedUser = false;

    }

}
