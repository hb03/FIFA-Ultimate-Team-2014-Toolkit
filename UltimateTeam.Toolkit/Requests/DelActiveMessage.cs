using System.Net.Http;
using System.Threading.Tasks;
using UltimateTeam.Toolkit.Constants;
using UltimateTeam.Toolkit.Models;

namespace UltimateTeam.Toolkit.Requests
{
    internal class DelActiveMessageRequest : FutRequestBase, IFutRequest<byte>
    {
        private readonly int _id;

        public DelActiveMessageRequest(int id)
        {
            _id = id;
        }

        public async Task<byte> PerformRequestAsync()
        {
            AddMethodOverrideHeader(HttpMethod.Delete);
            AddCommonHeaders();
            await HttpClient
                .PostAsync(string.Format(Resources.FutHome + Resources.DelActiveMessage, _id), new StringContent(" "))
                .ConfigureAwait(false);

            return 0;
        }
    }
}
