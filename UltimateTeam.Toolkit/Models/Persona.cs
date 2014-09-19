using System.Collections.Generic;

namespace UltimateTeam.Toolkit.Models
{
    public class Persona
    {
        public long PersonaId { get; set; }

        public string PersonaName { get; set; }

        public IEnumerable<UserClub> UserClubList { get; set; }

        public bool returningUser { get; set; }

        public bool trial { get; set; }

        public string userState { get; set; }

    }
}