using Parcial2.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.tests
{
    public class DamageCalculatorTests
    {
        [Test]
        public void Damage_SuperEffective()
        {
            var attacker = new Pokemon("Charmander", new List<PokemonType> { PokemonType.Fire })
            {
                Level = 30,
                SpecialAttack = 120
            };
            var defender = new Pokemon("Bulbasaur", new List<PokemonType> { PokemonType.Grass })
            {
                SpecialDefense = 60
            };
            var move = new Move("Flamethrower", PokemonType.Fire, MoveType.Special, power: 90);

            int damage = DamageCalculator.CalculateDamage(attacker, defender, move);

            Assert.Greater(damage, 0);
            Assert.Greater(damage, 50); // debería ser bastante daño por 2x
        }

        [Test]
        public void Damage_NoEffect()
        {
            var attacker = new Pokemon("Pikachu", new List<PokemonType> { PokemonType.Electric })
            {
                Level = 20,
                SpecialAttack = 80
            };
            var defender = new Pokemon("Geodude", new List<PokemonType> { PokemonType.Ground })
            {
                SpecialDefense = 80
            };
            var move = new Move("Thunderbolt", PokemonType.Electric, MoveType.Special, power: 90);

            int damage = DamageCalculator.CalculateDamage(attacker, defender, move);

            Assert.AreEqual(0, damage); // Electric no afecta a Ground
        }

        [TestCase(1, 1, 1, 1, 1, 0, 0)]          // Case 1
        [TestCase(1, 1, 1, 1, 1, 1, 1)]          // Case 2
        [TestCase(5, 50, 100, 100, 50, 2, 16)]   // Case 3
        [TestCase(5, 50, 100, 100, 50, 1, 5)]    // Case 4
        [TestCase(10, 20, 30, 30, 15, 1, 5)]     // Case 5
        [TestCase(12, 40, 60, 60, 80, 2, 9)]     // Case 6
        [TestCase(25, 80, 120, 120, 60, 1, 40)]  // Case 7
        [TestCase(30, 100, 50, 50, 100, 4, 58)]  // Case 8
        [TestCase(40, 150, 200, 200, 150, 1, 37)]// Case 9
        [TestCase(50, 128, 200, 200, 100, 1, 58)]// Case 10
        [TestCase(50, 128, 200, 200, 100, 4, 455)]// Case 11
        [TestCase(60, 200, 250, 250, 200, 1, 132)]// Case 12
        [TestCase(70, 180, 200, 200, 100, 2, 435)]// Case 13
        [TestCase(80, 90, 45, 45, 90, 1, 33)]    // Case 14
        [TestCase(90, 255, 200, 200, 50, 2, 1554)]// Case 15
        [TestCase(99, 255, 255, 255, 1, 2, 108206)]// Case 16
        [TestCase(99, 255, 255, 255, 255, 4, 856)] // Case 17
        [TestCase(99, 255, 255, 255, 255, 0, 0)]   // Case 18
        [TestCase(99, 255, 255, 1, 255, 1, 2)]     // Case 19
        [TestCase(45, 60, 10, 10, 200, 1, 2)]      // Case 20
        [TestCase(20, 30, 5, 5, 250, 1, 1)]        // Case 21
        [TestCase(2, 10, 1, 1, 255, 1, 1)]         // Case 22
        [TestCase(3, 5, 2, 2, 3, 1, 1)]            // Case 23
        [TestCase(15, 200, 255, 255, 255, 1, 33)]  // Case 24
        [TestCase(16, 200, 200, 200, 254, 1, 34)]  // Case 25
        [TestCase(17, 200, 200, 200, 128, 1, 36)]  // Case 26
        [TestCase(33, 77, 77, 77, 77, 1, 25)]      // Case 27
        [TestCase(48, 33, 99, 99, 11, 4, 508)]     // Case 28
        [TestCase(55, 44, 88, 88, 22, 1, 44)]      // Case 29
        [TestCase(66, 11, 11, 11, 11, 1, 8)]       // Case 30
        [TestCase(77, 123, 200, 200, 100, 2, 326)] // Case 31
        [TestCase(88, 200, 200, 200, 50, 4, 1197)] // Case 32
        [TestCase(100, 200, 200, 200, 200, 0, 0)]  // Case 33
        [TestCase(50, 255, 100, 100, 50, 0, 0)]    // Case 34
        [TestCase(75, 180, 255, 255, 180, 0, 0)]   // Case 35
        [TestCase(99, 255, 255, 255, 1, 0, 0)]     // Case 36
        [TestCase(25, 60, 40, 40, 20, 0, 0)]       // Case 37
        [TestCase(60, 100, 255, 255, 128, 1, 40)]  // Case 38
        [TestCase(80, 90, 45, 45, 90, 1, 17)]      // Case 39
        [TestCase(99, 200, 150, 150, 150, 1, 84)]  // Case 40
        public void TestDamageFormula(
            int level, int power, int attack, int spAttack, int defense,
            int mod, int expectedDamage)
        {
            // Creamos Pokémon dummy con los stats
            var attacker = new Pokemon("Attacker", new List<PokemonType> { PokemonType.Fire })
            {
                Level = level,
                Attack = attack,
                SpecialAttack = spAttack
            };

            var defender = new Pokemon("Defender", new List<PokemonType> { PokemonType.Grass })
            {
                Defense = defense,
                SpecialDefense = defense
            };            

            // Forzamos el multiplicador mod desde afuera (en lugar de TypeChart)
            double baseDamage = (((2.0 * level / 5.0) + 2) * power * (attack / (double)defense)) / 50.0 + 2;
            double finalDamage = baseDamage * mod;

            int result = (int)System.Math.Floor(finalDamage);

            Assert.AreEqual(expectedDamage, result);
        }
    }
}
