using Modsi.QueryAttribute;
using Newtonsoft.Json;
using Stubhub.ClientLibrary.Models.Inventory;
using Stubhub.ClientLibrary.Transfer.Events;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Stubhub.ClientLibrary.Models.Categories;
using Stubhub.ClientLibrary.Models.Events;
using Stubhub.ClientLibrary.Models.Venues;

namespace Stubhub.ClientLibrary
{
    public interface IStubhubService
    {
        Task<InventorySearch> GetInventory(int EventId);
        Task<EventSearch> SearchEvents(EventSearchRequest request, int page = 1);
        Task GetPerformers();
        Task<SearchCategories> GetCategories();
        Task<SearchVenues> GetVenues(int start = 0);
    }

    public class StubhubService : IStubhubService
    {
        private HttpClient _client;
        private const string APPLICATION_TOKEN = "68cd2e88-d89a-3e23-a13b-fee87af369d4";

        public StubhubService()
        {
            this._client = this.BuildClient();
        }

        public HttpClient BuildClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + APPLICATION_TOKEN);

            return client;
        }

        public async Task<InventorySearch> GetInventory(int EventId)
        {
            var req = await this._client.GetAsync("https://api.stubhub.com/search/inventory/v2/?eventId=" + EventId);
            var res = await req.Content.ReadAsStringAsync();
            InventorySearch jResponse = JsonConvert.DeserializeObject<InventorySearch>(res);

            return jResponse;
        }

        public async Task<EventSearch> SearchEvents(EventSearchRequest request, int page = 1)
        {
            var row = 50 * page;

            var query = QueryHandler.BuildQuery(request);
            var req = await this._client.GetAsync($"https://api.stubhub.com/search/catalog/events/v3{query}&rows=10&start={row}");
            var res = await req.Content.ReadAsStringAsync();
            EventSearch jResponse = JsonConvert.DeserializeObject<EventSearch>(res);

            return jResponse;
        }

        public async Task GetEventDetails()
        {
            
        }

        public async Task GetPerformers()
        {
            var req = await this._client.GetAsync("https://api.stubhub.com/search/catalog/performers/v3");
            var res = await req.Content.ReadAsStringAsync();
        }

        public async Task<SearchCategories> GetCategories()
        {
            var req = await this._client.GetAsync("https://api.stubhub.com/search/catalog/groupings/v3?rows=500");
            var res = await req.Content.ReadAsStringAsync();
            SearchCategories jResponse = JsonConvert.DeserializeObject<SearchCategories>(res);

            return jResponse;
        }

        public async Task<SearchVenues> GetVenues(int start = 0)
        {
            var req = await this._client.GetAsync($"https://api.stubhub.com/search/catalog/venues/v3/?rows=500&country=US&start={start}");
            var res = await req.Content.ReadAsStringAsync();
            SearchVenues jResponse = JsonConvert.DeserializeObject<SearchVenues>(res);

            return jResponse;
        }
    }
}
