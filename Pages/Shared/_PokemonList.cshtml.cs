using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using envision_horizons_pokemonapi.Models; // Include the namespace to access Pokemon and envision_horizons_pokemonapiResponse models.
using envision_horizons_pokemonapi.Services; // Include the namespace to access PokemonService.
using envision_horizons_pokemonapi.Models;

namespace envision_horizons_pokemonapi.Pages
{
    public class PokemonList : PageModel
    {
        private readonly PokemonService _pokemonService;

        public PokemonList(PokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }

        public List<PokemonResult> PokemonResults { get; set; }

        public async Task OnGetAsync()
        {
            var response = await _pokemonService.FetchPokemonData("https://pokeapi.co/api/v2/pokemon/");
            PokemonResults = response.Results;
        }
    }
}
