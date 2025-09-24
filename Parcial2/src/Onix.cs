using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.src
{
    internal class Onix : Pokemon
    {
        public Onix() : base("Onix", new List<PokemonType> { PokemonType.Rock, PokemonType.Ground })
        {
            Level = 1;
            Attack = 45;
            Defense = 160;
            SpecialAttack = 30;
            SpecialDefense = 45;
        }
    }
}
