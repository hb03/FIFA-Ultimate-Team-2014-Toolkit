using System.Collections.Generic;

namespace UltimateTeam.Toolkit.Models
{
    public class ActiveMessageResponse
    {

        public List<MessageResponse> activeMessage { get; set; }

    }

    public class MessageResponse
    {
        public int id { get; set; }

        public string message { get; set; }
        public string read { get; set; }
        public string rewardType { get; set; }
        public string rewardValue { get; set; }
        public string startTime { get; set; }
        public string time { get; set; }
        public string type { get; set; }
    }
}
