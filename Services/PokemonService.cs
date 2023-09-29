using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using envision_horizons_pokemonapi.Models;

namespace envision_horizons_pokemonapi.Services
{
    public class PokemonService
    {
        private readonly HttpClient _httpClient;

        public PokemonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PokemonApiResponse> FetchPokemonData(string url)
        {
            var response = await _httpClient.GetAsync(url);
            var responseData = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<PokemonApiResponse>(responseData);
        }

        public async Task<PokemonDetail> FetchPokemonDetail(string url)
        {
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<PokemonDetail>();
        }
    }
}
