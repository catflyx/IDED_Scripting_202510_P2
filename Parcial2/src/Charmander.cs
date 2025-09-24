using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.src
{    internal class Charmander : Pokemon
    {
        public Charmander() : base("Charmander", new List<PokemonType> { PokemonType.Fire })
        {
            Level = 1;
            Attack = 52;
            Defense = 43;
            SpecialAttack = 60;
            SpecialDefense = 50;
        }
    }
}
