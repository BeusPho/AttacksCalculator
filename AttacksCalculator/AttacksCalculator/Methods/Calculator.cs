namespace AttacksCalculator.Methods;

public class Calculator
{
    public static double WoundDiceResult(double hits, int index)
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

    public static double GoodDiceResult(double amount, string result) => result switch
    {
        "2+" => amount * 5 / 6,
        "3+" => amount * 2 / 3,
        "4+" => amount / 2,
        "5+" => amount / 3,
        "6+" => amount / 6,
        _ => throw new NotImplementedException(),
    };

    internal static double BadDiceResult(double amount, string result) => result switch
    {
        "2+" => amount / 6,
        "3+" => amount / 3,
        "4+" => amount / 2,
        "5+" => amount * 2 / 3,
        "6+" => amount * 5 / 6,
        "-" => amount,
        _ => throw new NotImplementedException(),
    };

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

    internal static double HitDiceResult(double attacks, int index)
    {
        return attacks * DieResult(index);
    }

    internal static double HitDiceRerollOneFailed(double attacks, int index)
    {
        var p = DieResult(index);
        return p * (attacks + 1 - Math.Pow((1 - p), attacks));
    }

    internal static double HitDiceCritRerollOneFailed(double attacks, int index)
    {
        var p = CritOnDie(index);
        return p * (attacks + 1 - Math.Pow((1 - p), attacks));
    }

    private static double DieResult(int index)
    {
        return index switch
        {
            0 => (double) 5 / 6,
            1 => (double) 2 / 3,
            2 => (double) 1 / 2,
            3 => (double) 1 / 3,
            4 => (double) 1 / 6,
            _ => throw new NotImplementedException(),
        };
    }

    internal static double DefenseDiceResult(double attacks, int index) => index switch
    {
        5 => attacks,
        4 => attacks * 5 / 6,
        3 => attacks * 2 / 3,
        2 => attacks / 2,
        1 => attacks / 3,
        0 => attacks / 6,
        _ => throw new NotImplementedException(),
    };

    internal static double CritOnDice(double attacks, int index)
    {
        return attacks * CritOnDie(index);
    }

    private static double CritOnDie(int index)
    {
        return index switch
        {
            4 => (double) 5 / 6,
            3 => (double) 2 / 3,
            2 => (double) 1 / 2,
            1 => (double) 1 / 3,
            0 => (double) 1 / 6,
            _ => throw new NotImplementedException(),
        };
    }
}
