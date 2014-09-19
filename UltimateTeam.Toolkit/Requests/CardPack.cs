using System.Net.Http;
using System.Threading.Tasks;
using UltimateTeam.Toolkit.Constants;
using UltimateTeam.Toolkit.Models;
using System;

namespace UltimateTeam.Toolkit.Requests
{
    internal class CardPackRequest : FutRequestBase, IFutRequest<CardPackResponse>
    {
        public async Task<CardPackResponse> PerformRequestAsync()
        {
            CardPackResponse cardPackResponse = null;
            try{
                AddMethodOverrideHeader(HttpMethod.Get);
                AddCommonHeaders();
                var cardPackResponseMessage = await HttpClient
                    .GetAsync(string.Format(Resources.FutHome + Resources.CardPack))
                    .ConfigureAwait(false);
                cardPackResponse = await Deserialize<CardPackResponse>(cardPackResponseMessage);
            } catch(Exception ex){
                var fehler = ex.Message;
            }
            return cardPackResponse;
        }
    }
}
