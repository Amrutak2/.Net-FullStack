using FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FrontEnd.Services
{
    public class RollServices
    {
        private readonly HttpClient _client;
        public const string BasePath = "/api/Employee";

        public RollServices(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        //public async Task<IEnumerable<SupplyData>> Find()
        //{
        //    var response = await _client.GetAsync(BasePath);

        //    return await response.ReadContentAsync<List<SupplyData>>();
        //}
    }
}
