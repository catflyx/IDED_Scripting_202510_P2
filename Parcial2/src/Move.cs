namespace Parcial2.src
{
    public class Move
    {
        public string Name { get; set; }
        public int Power { get; set; } = 100;
        public int Speed { get; set; } = 1;
        public PokemonType Type { get; set; }
        public MoveType MoveType { get; set; }

        public Move(string name, PokemonType type, MoveType moveType, int power = 100, int speed = 1)
        {
            Name = name;
            Power = power;
            Speed = speed;
            Type = type;
            MoveType = moveType;
        }
    }
}
