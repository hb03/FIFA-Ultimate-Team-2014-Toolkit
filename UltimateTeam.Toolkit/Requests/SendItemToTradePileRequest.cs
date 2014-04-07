using System.Net.Http;
using System.Threading.Tasks;
using UltimateTeam.Toolkit.Constants;
using UltimateTeam.Toolkit.Models;
using UltimateTeam.Toolkit.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace UltimateTeam.Toolkit.Requests
{
    internal class SendItemToTradePileRequest : FutRequestBase, IFutRequest<SendItemToTradePileResponse>
    {
        private readonly IEnumerable<ItemData> _itemData;

        public SendItemToTradePileRequest(IEnumerable<ItemData> itemData)
        {
            itemData.ThrowIfNullArgument();
            _itemData = itemData;
        }

        public async Task<SendItemToTradePileResponse> PerformRequestAsync()
        {
            AddMethodOverrideHeader(HttpMethod.Put);
            AddCommonHeaders();
            string content;
            if (_itemData.Count() > 1)
            {
                var itemIds = string.Join("\",\"pile\":\"trade\"},{\"id\":\"", _itemData.Select(p => p.Id));
                content = string.Format("{{\"itemData\":[{{\"id\":\"{0}\",\"pile\":\"trade\"}}]}}", itemIds);
            } else {
                content = string.Format("{{\"itemData\":[{{\"id\":\"{0}\",\"pile\":\"trade\"}}]}}", _itemData.First().Id);
            }
            var tradepileResponseMessage = await HttpClient
                .PostAsync(string.Format(Resources.FutHome + Resources.ListItem), new StringContent(content))
                .ConfigureAwait(false);

            return await Deserialize<SendItemToTradePileResponse>(tradepileResponseMessage);
        }
    }
}
