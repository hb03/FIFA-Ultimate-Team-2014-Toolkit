using System.Net.Http;
using System.Threading.Tasks;
using UltimateTeam.Toolkit.Constants;
using UltimateTeam.Toolkit.Models;
using System;

namespace UltimateTeam.Toolkit.Requests
{
    internal class PurchasedItemRequest : FutRequestBase, IFutRequest<PurchasedItemsResponse>
    {
        private readonly PurchasedItem _purchasedItem;

        public PurchasedItemRequest(PurchasedItem purchasedItem)
        {
            _purchasedItem = purchasedItem;
        }
        public async Task<PurchasedItemsResponse> PerformRequestAsync()
        {
            PurchasedItemsResponse purchasedItemsResponse = null;
            try
            {
                AddMethodOverrideHeader(HttpMethod.Post);
                AddCommonHeaders();
                var content = "{\"packId\":" + _purchasedItem.packId.ToString() + ",\"useCredits\":" + _purchasedItem.useCredits.ToString() + ",\"usePreOrder\":" + _purchasedItem.usePreOrder.ToString().ToLower() + "}";
                var purchasedItemResponseMessage = await HttpClient
                    .PostAsync(string.Format(Resources.FutHome + Resources.PurchasedItems), new StringContent(content))
                    .ConfigureAwait(false);
                purchasedItemsResponse = await Deserialize<PurchasedItemsResponse>(purchasedItemResponseMessage);
            }
            catch (Exception ex)
            {
                var fehler = ex.Message;
            }
            return purchasedItemsResponse;
        }
    }
}
