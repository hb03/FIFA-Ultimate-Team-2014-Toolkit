using System.Net.Http;
using System.Threading.Tasks;
using UltimateTeam.Toolkit.Constants;
using UltimateTeam.Toolkit.Models;

namespace UltimateTeam.Toolkit.Requests
{
    internal class ConsumablesDetailsRequest : FutRequestBase, IFutRequest<ConsumablesDetailsResponse>
    {
        private readonly ConsumablesDetailsCategory _consumablesDetailsCategory;

        public ConsumablesDetailsRequest(ConsumablesDetailsCategory consumablesDetailsCategory)
        {
            _consumablesDetailsCategory = consumablesDetailsCategory;
        }

        public async Task<ConsumablesDetailsResponse> PerformRequestAsync()
        {
            AddCommonHeaders();
            AddMethodOverrideHeader(HttpMethod.Get);
            var consumablesDetailsResponseMessage = await HttpClient
                .GetAsync(string.Format(Resources.FutHome + string.Format(Resources.ConsumablesDetails, _consumablesDetailsCategory)))
                .ConfigureAwait(false);

            return await Deserialize<ConsumablesDetailsResponse>(consumablesDetailsResponseMessage);
        }
    }
}
