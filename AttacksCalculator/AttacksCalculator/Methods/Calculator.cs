using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttacksCalculator.Methods;

public class Calculator
{
    public static double WoundDiceResult(double hits, int index, bool devastating)
    {
        if (devastating is false)
        {
            return index switch
            {
                0 => hits * 5 / 6,
                1 => hits * 2 / 3,
                2 => hits / 2,
                3 => hits / 3,
                4 => hits / 6,
                _ => throw new NotImplementedException(),
            };
        }

        return index switch
        {
            0 => hits * 2 / 3,
            1 => hits / 2,
            2 => hits / 3,
            3 => hits / 6,
            4 => 0,
            _ => throw new NotImplementedException(),
        };
    }

    public static double WoundWithFullReroll(double hits, int index, bool devastating)
    {
        var successfulWounds = WoundDiceResult(hits, index, devastating);
        var crits = hits / 6;
        return successfulWounds + WoundDiceResult(hits - (successfulWounds + (devastating ? crits : 0)), index, devastating);
    }

    internal static double CalculateFnp(double damage, int index)
    {
        return index switch
        {
            0 => damage,
            1 => damage * 5 / 6,
            2 => damage * 2 / 3,
            3 => damage / 2,
            _ => throw new NotImplementedException(),
        };
    }

    internal static double AttackDiceResult(double attacks, int index, bool lethal)
    {
        if (lethal is false)
        {
            return index switch
            {
                0 => attacks * 5 / 6,
                1 => attacks * 2 / 3,
                2 => attacks / 2,
                3 => attacks / 3,
                4 => attacks / 6,
                _ => throw new NotImplementedException(),
            };
        }

        return index switch
        {
            0 => attacks * 2 / 3,
            1 => attacks / 2,
            2 => attacks / 3,
            3 => attacks / 6,
            4 => 0,
            _ => throw new NotImplementedException(),
        };
    }
}
