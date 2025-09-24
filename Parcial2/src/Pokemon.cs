﻿namespace Parcial2.src
{
    internal class Pokemon
    {
        public string Name { get; set; }
        public int Level { get; set; } = 1;
        public int Attack { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int SpecialAttack { get; set; } = 10;
        public int SpecialDefense { get; set; } = 10;
        public List<PokemonType> Types { get; set; } = new List<PokemonType>();
        public List<Move> Moves { get; set; } = new List<Move>();

        public Pokemon(string name, List<PokemonType> types)
        {
            Name = name;
            Types = types;
        }
    }
}
