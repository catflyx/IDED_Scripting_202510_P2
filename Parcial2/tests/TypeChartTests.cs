using NUnit.Framework;
using Parcial2.src;
using System;

namespace Parcial2.tests
{
    internal class TypeChartTests
    {
        [Test]
        public void RockVsFire_Es2x()
        {
            double mod = TypeChart.GetEffectiveness(PokemonType.Rock, PokemonType.Fire);
            Assert.AreEqual(2.0, mod);
        }

        [Test]
        public void ElectricVsGround_Es0x()
        {
            double mod = TypeChart.GetEffectiveness(PokemonType.Electric, PokemonType.Ground);
            Assert.AreEqual(0.0, mod);
        }

        [Test]
        public void GrassVsWater_Es2x()
        {
            double mod = TypeChart.GetEffectiveness(PokemonType.Grass, PokemonType.Water);
            Assert.AreEqual(2.0, mod);
        }

        [TestCase(PokemonType.Rock, PokemonType.Fire, 2.0)]
        [TestCase(PokemonType.Rock, PokemonType.Grass, 0.5)]
        [TestCase(PokemonType.Rock, PokemonType.Electric, 1.0)]
        [TestCase(PokemonType.Ground, PokemonType.Electric, 2.0)]
        [TestCase(PokemonType.Ground, PokemonType.Bug, 0.5)]
        [TestCase(PokemonType.Water, PokemonType.Fire, 2.0)]
        [TestCase(PokemonType.Water, PokemonType.Grass, 0.5)]
        [TestCase(PokemonType.Electric, PokemonType.Water, 2.0)]
        [TestCase(PokemonType.Electric, PokemonType.Ground, 0.0)]
        [TestCase(PokemonType.Fire, PokemonType.Grass, 2.0)]
        [TestCase(PokemonType.Grass, PokemonType.Water, 2.0)]
        [TestCase(PokemonType.Grass, PokemonType.Fire, 0.5)]
        [TestCase(PokemonType.Ghost, PokemonType.Psychic, 2.0)]        
        [TestCase(PokemonType.Poison, PokemonType.Grass, 2.0)]
        [TestCase(PokemonType.Poison, PokemonType.Rock, 0.5)]
        [TestCase(PokemonType.Psychic, PokemonType.Poison, 2.0)]
        [TestCase(PokemonType.Psychic, PokemonType.Ghost, 0.0)]
        [TestCase(PokemonType.Bug, PokemonType.Grass, 2.0)]
        [TestCase(PokemonType.Bug, PokemonType.Fire, 0.5)]
        public void TestEffectiveness(PokemonType attack, PokemonType defend, double expected)
        {
            double result = TypeChart.GetEffectiveness(attack, defend);
            Assert.AreEqual(expected, result);
        }
    }
}
