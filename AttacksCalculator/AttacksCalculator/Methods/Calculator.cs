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

    internal static double AttackDiceResult(double attacks, int index)
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
}
