using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.src
{
    internal class Gastly : Pokemon
    {
        public Gastly() : base("Gastly", new List<PokemonType> { PokemonType.Ghost, PokemonType.Poison })
        {
            Level = 1;
            Attack = 35;
            Defense = 30;
            SpecialAttack = 100;
            SpecialDefense = 35;
        }
    }
}
