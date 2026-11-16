using Library.Core;

namespace Library.Tests;

[TestClass]
public class FeeCalculatorTests
{
    [TestMethod]
    public void Calculate_AfleveretTilTiden_Returnerer0()
    {
        // Arrange
        var calculator = new FeeCalculator();
        var due = new DateTime(2026, 11, 30);

        // Act
        decimal fee = calculator.Calculate(due, due);

        // Assert
        Assert.AreEqual(0m, fee);
    }

    [TestMethod]
    public void Calculate_EnDagForSent_Returnerer5()
    {
        // Arrange
        var calculator = new FeeCalculator();
        var due = new DateTime(2026, 11, 30);
        var returned = new DateTime(2026, 12, 1);

        // Act
        decimal fee = calculator.Calculate(due, returned);

        // Assert
        Assert.AreEqual(5m, fee);
    }

    [TestMethod]
    public void Calculate_AfleveretFoerTid_Returnerer0()
    {
        // Arrange
        var calculator = new FeeCalculator();
        var due = new DateTime(2026, 11, 30);
        var returned = new DateTime(2026, 11, 25);

        // Act
        decimal fee = calculator.Calculate(due, returned);

        // Assert
        Assert.AreEqual(0m, fee);
    }
}
