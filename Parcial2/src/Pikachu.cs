namespace Parcial2.src
{
    internal class Pikachu : Pokemon
    {
        public Pikachu() : base("Pikachu", new List<PokemonType> { PokemonType.Electric })
        {
            Level = 1;
            Attack = 55;
            Defense = 40;
            SpecialAttack = 50;
            SpecialDefense = 50;
        }
    }
}
