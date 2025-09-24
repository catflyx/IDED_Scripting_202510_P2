using Parcial2.src;

namespace Parcial2.tests
{
    internal class PokemonTests
    {
        [Test]
        public void CrearPokemonPorDefecto_ValoresInicialesCorrectos()
        {
            var pikachu = new Pokemon("Pikachu", new List<PokemonType> { PokemonType.Electric });

            Assert.AreEqual("Pikachu", pikachu.Name);
            Assert.AreEqual(1, pikachu.Level);
            Assert.AreEqual(10, pikachu.Attack);
            Assert.AreEqual(10, pikachu.Defense);
            Assert.AreEqual(10, pikachu.SpecialAttack);
            Assert.AreEqual(10, pikachu.SpecialDefense);
            Assert.AreEqual(PokemonType.Electric, pikachu.Types[0]);
        }
    }
}
