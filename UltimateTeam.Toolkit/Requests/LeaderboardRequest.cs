using System.Net.Http;
using System.Threading.Tasks;
using UltimateTeam.Toolkit.Constants;
using UltimateTeam.Toolkit.Models;

namespace UltimateTeam.Toolkit.Requests
{
    internal class LeaderboardRequest : FutRequestBase, IFutRequest<LeaderboardResponse>
    {
        private long _personaId;

        public LeaderboardRequest(long personaId)
        {
            _personaId = personaId;
        }

        public async Task<LeaderboardResponse> PerformRequestAsync()
        {
            AddMethodOverrideHeader(HttpMethod.Get);
            AddCommonHeaders();
            var link = string.Format(Resources.Leaderboard, _personaId);
            var leaderboardResponseMessage = await HttpClient.PostAsync(string.Format(Resources.FutHome + link), new StringContent(""))
                .ConfigureAwait(false);

            return await Deserialize<LeaderboardResponse>(leaderboardResponseMessage);
        }
    }
}
