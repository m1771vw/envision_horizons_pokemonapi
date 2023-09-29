using System.Collections.Generic;

namespace envision_horizons_pokemonapi.Models
{
  public class PokemonApiResponse
  {
    public int Count { get; set; }
    public string Next { get; set; }
    public string Previous { get; set; }
    public List<PokemonResult> Results { get; set; }
  }


}
