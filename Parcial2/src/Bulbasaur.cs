using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.src
{
    public class Bulbasaur : Pokemon
    {
        public Bulbasaur() : base("Bulbasaur", new List<PokemonType> { PokemonType.Grass, PokemonType.Poison })
        {
            Level = 1;
            Attack = 49;
            Defense = 49;
            SpecialAttack = 65;
            SpecialDefense = 65;
        }
    }
}
