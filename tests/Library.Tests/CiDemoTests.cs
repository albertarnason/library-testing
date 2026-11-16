namespace Library.Tests;

[TestClass]
public class CiDemoTests
{
    [TestMethod]
    public void Demo_BevidstFejlendeTest_SkalFejle()
    {
        // Arrange
        var expected = 1;

        // Act
        var actual = 2;

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
