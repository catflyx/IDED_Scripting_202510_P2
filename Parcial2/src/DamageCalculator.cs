using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.src
{
    public static class DamageCalculator
    {
        public static int CalculateDamage(Pokemon attacker, Pokemon defender, Move move)
        {
            // 1. Selección de stats según el tipo de movimiento
            double attackStat = (move.MoveType == MoveType.Physical) ? attacker.Attack : attacker.SpecialAttack;
            double defenseStat = (move.MoveType == MoveType.Physical) ? defender.Defense : defender.SpecialDefense;

            // 2. Fórmula base
            double baseDamage = (((2.0 * attacker.Level / 5.0) + 2) * move.Power * (attackStat / defenseStat)) / 50.0 + 2;

            // 3. Cálculo del modificador por tipos
            double mod = TypeChart.GetEffectiveness(move.Type, defender.Types[0]);
            if (defender.Types.Count > 1)
            {
                mod *= TypeChart.GetEffectiveness(move.Type, defender.Types[1]);
            }

            // 4. Daño final
            double finalDamage = baseDamage * mod;

            return (int)Math.Floor(finalDamage); // se redondea hacia abajo como en Pokémon
        }
    }
}
