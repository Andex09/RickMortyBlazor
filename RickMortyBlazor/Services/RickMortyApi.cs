using System.Net.Http.Json;
using System.Net;
using RickMortyBlazor.Models;
using RickMortyBlazor.Client.Services.Interfaces;

namespace RickMortyBlazor.Client.Services
{
    public class RickMortyApi : IRickMortyApi
    {
        HttpClient _httpClient;
        public RickMortyApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        #region Characters

        public async Task<GeneralResponse<Character>> GetAllChararters(PaginationParameters parameters)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"character/?page={parameters.PageNumber}");

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            GeneralResponse<Character> responseJson = await response.Content.ReadFromJsonAsync<GeneralResponse<Character>>();
            return responseJson;
        }

        public async Task<Character> GetChararter(int id)
        {
            var response = await _httpClient.GetAsync($"character/{id}");

            if (response.IsSuccessStatusCode)
            {
                Character responseJson = await response.Content.ReadFromJsonAsync<Character>();
                return responseJson;
            }

            return null;
        }

        public async Task<GeneralResponse<Character>> GetSearchChararters(PaginationParameters parameters, Filter query)
        {

            string url = "character/?";
            if (!string.IsNullOrEmpty(query.Name))
                url += $"name={query.Name}";

            if (query.Status != null)
                url += $"&status={query.Status.Value}";

            var response = await _httpClient.GetAsync($"{url}&page={parameters.PageNumber}");

            if (response.IsSuccessStatusCode)
            {
                var responseJson = await response.Content.ReadFromJsonAsync<GeneralResponse<Character>>();
                return responseJson;
            }

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }

            return null;
        }
        #endregion

        public async Task<Episode> GetEpisode(int id)
        {
            var response = await _httpClient.GetAsync($"episode/{id}");

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<Episode>();
                Episode responseJson = result;
                return responseJson;
            }

            return null;
        }
    }
}
