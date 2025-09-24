using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.src
{
    internal class TypeChart
    {
        private static readonly Dictionary<(PokemonType, PokemonType), double> chart =
            new Dictionary<(PokemonType, PokemonType), double>
        {
            // Rock
            {(PokemonType.Rock, PokemonType.Rock), 1.0},
            {(PokemonType.Rock, PokemonType.Ground), 0.5},
            {(PokemonType.Rock, PokemonType.Water), 1.0},
            {(PokemonType.Rock, PokemonType.Electric), 1.0},
            {(PokemonType.Rock, PokemonType.Fire), 2.0},
            {(PokemonType.Rock, PokemonType.Grass), 0.5},
            {(PokemonType.Rock, PokemonType.Ghost), 1.0},
            {(PokemonType.Rock, PokemonType.Poison), 1.0},
            {(PokemonType.Rock, PokemonType.Psychic), 1.0},
            {(PokemonType.Rock, PokemonType.Bug), 2.0},

            // Ground
            {(PokemonType.Ground, PokemonType.Rock), 2.0},
            {(PokemonType.Ground, PokemonType.Ground), 1.0},
            {(PokemonType.Ground, PokemonType.Water), 1.0},
            {(PokemonType.Ground, PokemonType.Electric), 2.0},
            {(PokemonType.Ground, PokemonType.Fire), 1.0},
            {(PokemonType.Ground, PokemonType.Grass), 0.5},
            {(PokemonType.Ground, PokemonType.Ghost), 1.0},
            {(PokemonType.Ground, PokemonType.Poison), 2.0},
            {(PokemonType.Ground, PokemonType.Psychic), 1.0},
            {(PokemonType.Ground, PokemonType.Bug), 0.5},

            // Water
            {(PokemonType.Water, PokemonType.Rock), 2.0},
            {(PokemonType.Water, PokemonType.Ground), 2.0},
            {(PokemonType.Water, PokemonType.Water), 0.5},
            {(PokemonType.Water, PokemonType.Electric), 1.0},
            {(PokemonType.Water, PokemonType.Fire), 2.0},
            {(PokemonType.Water, PokemonType.Grass), 0.5},
            {(PokemonType.Water, PokemonType.Ghost), 1.0},
            {(PokemonType.Water, PokemonType.Poison), 1.0},
            {(PokemonType.Water, PokemonType.Psychic), 1.0},
            {(PokemonType.Water, PokemonType.Bug), 1.0},

            // Electric
            {(PokemonType.Electric, PokemonType.Rock), 1.0},
            {(PokemonType.Electric, PokemonType.Ground), 0.0},
            {(PokemonType.Electric, PokemonType.Water), 2.0},
            {(PokemonType.Electric, PokemonType.Electric), 0.5},
            {(PokemonType.Electric, PokemonType.Fire), 1.0},
            {(PokemonType.Electric, PokemonType.Grass), 0.5},
            {(PokemonType.Electric, PokemonType.Ghost), 1.0},
            {(PokemonType.Electric, PokemonType.Poison), 1.0},
            {(PokemonType.Electric, PokemonType.Psychic), 1.0},
            {(PokemonType.Electric, PokemonType.Bug), 1.0},

            // Fire
            {(PokemonType.Fire, PokemonType.Rock), 0.5},
            {(PokemonType.Fire, PokemonType.Ground), 1.0},
            {(PokemonType.Fire, PokemonType.Water), 0.5},
            {(PokemonType.Fire, PokemonType.Electric), 1.0},
            {(PokemonType.Fire, PokemonType.Fire), 0.5},
            {(PokemonType.Fire, PokemonType.Grass), 2.0},
            {(PokemonType.Fire, PokemonType.Ghost), 1.0},
            {(PokemonType.Fire, PokemonType.Poison), 1.0},
            {(PokemonType.Fire, PokemonType.Psychic), 1.0},
            {(PokemonType.Fire, PokemonType.Bug), 2.0},

            // Grass
            {(PokemonType.Grass, PokemonType.Rock), 2.0},
            {(PokemonType.Grass, PokemonType.Ground), 2.0},
            {(PokemonType.Grass, PokemonType.Water), 2.0},
            {(PokemonType.Grass, PokemonType.Electric), 1.0},
            {(PokemonType.Grass, PokemonType.Fire), 0.5},
            {(PokemonType.Grass, PokemonType.Grass), 0.5},
            {(PokemonType.Grass, PokemonType.Ghost), 1.0},
            {(PokemonType.Grass, PokemonType.Poison), 0.5},
            {(PokemonType.Grass, PokemonType.Psychic), 1.0},
            {(PokemonType.Grass, PokemonType.Bug), 0.5},

            // Ghost
            {(PokemonType.Ghost, PokemonType.Rock), 1.0},
            {(PokemonType.Ghost, PokemonType.Ground), 1.0},
            {(PokemonType.Ghost, PokemonType.Water), 1.0},
            {(PokemonType.Ghost, PokemonType.Electric), 1.0},
            {(PokemonType.Ghost, PokemonType.Fire), 1.0},
            {(PokemonType.Ghost, PokemonType.Grass), 1.0},
            {(PokemonType.Ghost, PokemonType.Ghost), 2.0},
            {(PokemonType.Ghost, PokemonType.Poison), 0.5},
            {(PokemonType.Ghost, PokemonType.Psychic), 2.0},
            {(PokemonType.Ghost, PokemonType.Bug), 1.0},

            // Poison
            {(PokemonType.Poison, PokemonType.Rock), 0.5},
            {(PokemonType.Poison, PokemonType.Ground), 0.5},
            {(PokemonType.Poison, PokemonType.Water), 1.0},
            {(PokemonType.Poison, PokemonType.Electric), 1.0},
            {(PokemonType.Poison, PokemonType.Fire), 1.0},
            {(PokemonType.Poison, PokemonType.Grass), 2.0},
            {(PokemonType.Poison, PokemonType.Ghost), 0.5},
            {(PokemonType.Poison, PokemonType.Poison), 0.5},
            {(PokemonType.Poison, PokemonType.Psychic), 1.0},
            {(PokemonType.Poison, PokemonType.Bug), 2.0},

            // Psychic
            {(PokemonType.Psychic, PokemonType.Rock), 1.0},
            {(PokemonType.Psychic, PokemonType.Ground), 1.0},
            {(PokemonType.Psychic, PokemonType.Water), 1.0},
            {(PokemonType.Psychic, PokemonType.Electric), 1.0},
            {(PokemonType.Psychic, PokemonType.Fire), 1.0},
            {(PokemonType.Psychic, PokemonType.Grass), 1.0},
            {(PokemonType.Psychic, PokemonType.Ghost), 0.0},
            {(PokemonType.Psychic, PokemonType.Poison), 2.0},
            {(PokemonType.Psychic, PokemonType.Psychic), 0.5},
            {(PokemonType.Psychic, PokemonType.Bug), 1.0},

            // Bug
            {(PokemonType.Bug, PokemonType.Rock), 1.0},
            {(PokemonType.Bug, PokemonType.Ground), 1.0},
            {(PokemonType.Bug, PokemonType.Water), 1.0},
            {(PokemonType.Bug, PokemonType.Electric), 1.0},
            {(PokemonType.Bug, PokemonType.Fire), 0.5},
            {(PokemonType.Bug, PokemonType.Grass), 2.0},
            {(PokemonType.Bug, PokemonType.Ghost), 0.5},
            {(PokemonType.Bug, PokemonType.Poison), 0.5},
            {(PokemonType.Bug, PokemonType.Psychic), 2.0},
            {(PokemonType.Bug, PokemonType.Bug), 1.0},
        };

        public static double GetEffectiveness(PokemonType attack, PokemonType defend)
        {
            if (chart.TryGetValue((attack, defend), out double value))
            {
                return value;
            }
            return 1.0; // neutro por defecto
        }
    }
}
