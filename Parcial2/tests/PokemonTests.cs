using Parcial2.src;

namespace Parcial2.tests
{
    public class PokemonTests
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

        [Test]
        public void Pikachu_SeInicializaCorrecto()
        {
            var p = new Pikachu();
            Assert.AreEqual("Pikachu", p.Name);
            Assert.AreEqual(PokemonType.Electric, p.Types[0]);
            Assert.AreEqual(55, p.Attack);
        }

        [Test]
        public void Bulbasaur_TieneDosTipos()
        {
            var b = new Bulbasaur();
            Assert.Contains(PokemonType.Grass, b.Types);
            Assert.Contains(PokemonType.Poison, b.Types);
        }
    }
}
