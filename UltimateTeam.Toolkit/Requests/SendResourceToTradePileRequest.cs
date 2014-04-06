using System.Net.Http;
using System.Threading.Tasks;
using UltimateTeam.Toolkit.Constants;
using UltimateTeam.Toolkit.Models;
using UltimateTeam.Toolkit.Extensions;

namespace UltimateTeam.Toolkit.Requests
{
    internal class SendResourceToTradePileRequest : FutRequestBase, IFutRequest<SendResourceToTradePileResponse>
    {
        private readonly long _resourceId;

        public SendResourceToTradePileRequest(long resourceId)
        {
            resourceId.ThrowIfNullArgument();
            _resourceId = resourceId;
        }

        public async Task<SendResourceToTradePileResponse> PerformRequestAsync()
        {
            AddMethodOverrideHeader(HttpMethod.Put);
            AddCommonHeaders();
            var content = string.Format("{{\"itemData\":[{{\"id\":\"{0}\",\"pile\":\"trade\"}}]}}", _resourceId);
            var tradepileResponseMessage = await HttpClient
                .PostAsync(string.Format(Resources.FutHome + Resources.ListResource), new StringContent(content))
                .ConfigureAwait(false);

            return await Deserialize<SendResourceToTradePileResponse>(tradepileResponseMessage);
        }
    }
}
