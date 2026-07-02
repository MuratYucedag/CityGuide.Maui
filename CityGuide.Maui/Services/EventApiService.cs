using CityGuide.Maui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CityGuide.Maui.Services
{
    public class EventApiService
    {
        private readonly HttpClient _httpClient;

        // API'nin adresi (Swagger'da gördüğün port)
        private const string BaseUrl = "https://localhost:7056";
        public EventApiService()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<SpecialEvent>> GetEventsAsync()
        {
            // API'ye GET isteği at, JSON'u doğrudan List<SpecialEvent>'e çevir
            var events = await _httpClient.GetFromJsonAsync<List<SpecialEvent>>($"{BaseUrl}/api/events");
            return events ?? new List<SpecialEvent>();
        }
    }
}
