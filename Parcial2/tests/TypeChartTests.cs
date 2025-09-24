using Parcial2.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
