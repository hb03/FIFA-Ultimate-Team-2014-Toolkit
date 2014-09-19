using System.Net.Http;
using System.Threading.Tasks;
using UltimateTeam.Toolkit.Constants;
using UltimateTeam.Toolkit.Models;

namespace UltimateTeam.Toolkit.Requests
{
    internal class ActiveMessageRequest : FutRequestBase, IFutRequest<ActiveMessageResponse>
    {
        public async Task<ActiveMessageResponse> PerformRequestAsync()
        {
            AddMethodOverrideHeader(HttpMethod.Get);
            AddCommonHeaders();
            var activeMessageResponseMessage = await HttpClient
                .GetAsync(string.Format(Resources.FutHome + Resources.ActiveMessage))
                .ConfigureAwait(false);

            return await Deserialize<ActiveMessageResponse>(activeMessageResponseMessage);
        }
    }
}
