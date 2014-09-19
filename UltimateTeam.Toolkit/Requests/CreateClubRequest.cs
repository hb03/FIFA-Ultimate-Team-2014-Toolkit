using System.Net.Http;
using System.Threading.Tasks;
using UltimateTeam.Toolkit.Constants;
using UltimateTeam.Toolkit.Models;
using UltimateTeam.Toolkit.Exceptions;

using System;


namespace UltimateTeam.Toolkit.Requests
{
    internal class CreateClubRequest : FutRequestBase, IFutRequest<CreateClubResponse>
    {
        private readonly string _clubName;
        private readonly string _clubAbbr;

        public CreateClubRequest(string clubName, string clubAbbr)
        {
            _clubName = clubName;
            _clubAbbr = clubAbbr;
        }

        public async Task<CreateClubResponse> PerformRequestAsync()
        {
            System.Net.Http.HttpResponseMessage createClubResponseMessage = null;
            try
            {
                var content = "{\"useFut1Data\":\"false\",\"clubName\":\"" + _clubName + "\",\"clubAbbr\":\"" + _clubAbbr + "\"}";


                AddMethodOverrideHeader(HttpMethod.Post);
                AddCommonHeaders();
                createClubResponseMessage = await HttpClient
                    .PostAsync(string.Format(Resources.FutHome + Resources.User), new StringContent(content))
                    .ConfigureAwait(false);
                return await Deserialize<CreateClubResponse>(createClubResponseMessage);

            }
            catch (Exception ex)
            {
                var fehler = ex.Message;
            }

            return await Deserialize<CreateClubResponse>(createClubResponseMessage);
        }
    }
}
