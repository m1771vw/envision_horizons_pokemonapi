using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using envision_horizons_pokemonapi.Models;

namespace envision_horizons_pokemonapi.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientFactory _clientFactory;
        public PokemonApiResponse PokemonApiData { get; private set; }
        // private readonly PokemonService _pokemonService;
        public List<PokemonResult> PokemonResults { get; set; }


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            // _clientFactory = clientFactory;
            // _pokemonService = pokemonService;
        }

        public async Task OnGetAsync()
        {
            // var client = _clientFactory.CreateClient();
            // PokemonApiData = await client.GetFromJsonAsync<PokemonApiResponse>("https://pokeapi.co/api/v2/pokemon/?limit=20");
            // var response = await _pokemonService.FetchPokemonData("https://pokeapi.co/api/v2/pokemon/");
            // PokemonResults = response.Results;
        }
    }

}
