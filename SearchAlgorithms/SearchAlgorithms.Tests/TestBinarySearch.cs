using NUnit.Framework;
using SearchAlgorithms.BinarySearch;

namespace SearchAlgorithms.Tests;

public class BinarySearchTests
{
    private readonly BinarySearchAlgorithm _sut = new BinarySearchAlgorithm();

    [Test]
    public void Test_BinarySearch_ExistingItem()
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
    public void Test_BinarySearch_NotExistingItem()
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
    public void Test_BinarySearch_EmptyArray()
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
    public void Test_BinarySearch_NullArray()
    {
        // Arrange
        const int itemToFind = 50;

        // Act
        var itemIndex = this._sut.Search(null, itemToFind);

        // Assert
        Assert.AreEqual(-1, itemIndex);
    }
}