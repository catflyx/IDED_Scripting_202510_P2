using Parcial2.src;

namespace Parcial2.tests
{
    public class MoveTests
    {
        [Test]
        public void CrearMovePorDefecto_ValoresCorrectos()
        {
            var thunderbolt = new Move("Thunderbolt", PokemonType.Electric, MoveType.Special);

            Assert.AreEqual("Thunderbolt", thunderbolt.Name);
            Assert.AreEqual(100, thunderbolt.Power);
            Assert.AreEqual(1, thunderbolt.Speed);
            Assert.AreEqual(PokemonType.Electric, thunderbolt.Type);
            Assert.AreEqual(MoveType.Special, thunderbolt.MoveType);

            var move = new Move("Thunderbolt", PokemonType.Electric, MoveType.Special, 90, 100);
            Assert.AreEqual("Thunderbolt", move.Name);
            Assert.AreEqual(PokemonType.Electric, move.Type);
            Assert.AreEqual(MoveType.Special, move.MoveType);
            Assert.AreEqual(90, move.Power);
            Assert.AreEqual(100, move.Speed);
        
        }
    }
}
