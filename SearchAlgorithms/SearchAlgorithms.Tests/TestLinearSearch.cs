using NUnit.Framework;
using SearchAlgorithms.LinearSearch;

namespace SearchAlgorithms.Tests;

public class LinearSearchTests
{
    private readonly LinearSearchAlgorithm _sut = new LinearSearchAlgorithm();

    [Test]
    public void Test_LinearSearch_ExistingItem()
    {
        // Arrange
        var numbers = new[] { 1, 5, 39, 0, 21, 3, 2, 38 };
        const int itemToFind = 3;

        // Act
        var itemIndex = this._sut.Search(numbers, itemToFind);

        // Assert
        Assert.AreEqual(5, itemIndex);
    }

    [Test]
    public void Test_LinearSearch_NotExistingItem()
    {
        // Arrange
        var numbers = new[] { 1, 5, 39, 0, 21, 3, 2, 38 };
        const int itemToFind = 50;

        // Act
        var itemIndex = this._sut.Search(numbers, itemToFind);

        // Assert
        Assert.AreEqual(-1, itemIndex);
    }

    [Test]
    public void Test_LinearSearch_EmptyArray()
    {
        // Arrange
        var numbers = System.Array.Empty<int>();
        const int itemToFind = 50;

        // Act
        var itemIndex = this._sut.Search(numbers, itemToFind);

        // Assert
        Assert.AreEqual(-1, itemIndex);
    }

    [Test]
    public void Test_LinearSearch_NullArray()
    {
        // Arrange
        const int itemToFind = 50;

        // Act
        var itemIndex = this._sut.Search(null, itemToFind);

        // Assert
        Assert.AreEqual(-1, itemIndex);
    }
}