using PokeApiNet;

namespace fishportfolio.Data
{
    public class MyPokemon
    {
        public MyPokemon() { }
        public MyPokemon(MyPokemon myPokemon)
        {
            Pokemon = myPokemon.Pokemon;
            SpeciesCall = myPokemon.SpeciesCall;
        }
        public PokemonSpecies? SpeciesCall { get; set; }
        public Pokemon Pokemon { get; set; }
    }
}
