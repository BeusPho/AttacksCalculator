using AttacksCalculator.Methods;
using NUnit.Framework;

namespace AttacksCalculator.Tests;

[TestFixture]
public class Tests
{
    private static readonly string[] IndexArray = { "2+", "3+", "4+", "5+", "6+" };
    
    [Test]
    public void CalculateWoundDiceResult_WhenToWoundIsFourAndDevastatingIsOn()
    {
        // Arrange
        var rand = new Random();
        var attacks = rand.Next();

        // Act
        var result = Calculator.WoundDiceResult(attacks, 2, true);

        // Assert
        Assert.That(result, Is.EqualTo(attacks / 3));
    }

    [Test]
    public void CalculateWoundDiceResult_WhenToWoundIsFourAndDevastatingIsOff()
    {
        // Arrange
        var rand = new Random();
        var attacks = rand.Next();

        // Act
        var result = Calculator.WoundDiceResult(attacks, 2, false);

        // Assert
        Assert.That(result, Is.EqualTo(attacks / 2));
    }
}