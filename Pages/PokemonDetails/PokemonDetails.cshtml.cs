
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using envision_horizons_pokemonapi.Models;
using envision_horizons_pokemonapi.Services; // Include the namespace to access PokemonService.

namespace envision_horizons_pokemonapi.Pages
{
  public class PokemonDetailsModel : PageModel
  {
    private readonly PokemonService _pokemonService;

    public PokemonDetailsModel(PokemonService pokemonService)
    {
      _pokemonService = pokemonService;
    }

    public PokemonDetail Pokemon { get; set; }

    public async Task OnGetAsync(string url)
    {
      System.Console.WriteLine("HELLO?"+url);
      Pokemon = await _pokemonService.FetchPokemonDetail("https://pokeapi.co/api/v2/pokemon/1");
    }

  }

}