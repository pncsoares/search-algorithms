using NUnit.Framework;

namespace SearchAlgorithms.Tests;

public class BinarySearchTests
{
    private BinarySearch _sut { get; set; }

    [SetUp]
    public void Init()
    {
        _sut = new BinarySearch();
    }

    [Test]
    public void Test_BinarySearch_ExistingItem()
    {
        // Arrange
        var numbers = new int[] { 1, 5, 39, 0, 21, 3, 2, 38 };
        var itemToFind = 3;

        // Act
        var itemIndex = this._sut.Search(numbers, itemToFind);

        // Assert
        Assert.AreEqual(5, itemIndex);
    }

    [Test]
    public void Test_BinarySearch_NotExistingItem()
    {
        // Arrange
        var numbers = new int[] { 1, 5, 39, 0, 21, 3, 2, 38 };
        var itemToFind = 50;

        // Act
        var itemIndex = this._sut.Search(numbers, itemToFind);

        // Assert
        Assert.AreEqual(-1, itemIndex);
    }

    [Test]
    public void Test_BinarySearch_EmptyArray()
    {
        // Arrange
        int[] numbers = new int[] {};
        var itemToFind = 50;

        // Act
        var itemIndex = this._sut.Search(numbers, itemToFind);

        // Assert
        Assert.AreEqual(-1, itemIndex);
    }

    [Test]
    public void Test_BinarySearch_NullArray()
    {
        // Arrange
        var itemToFind = 50;

        // Act
        var itemIndex = this._sut.Search(null, itemToFind);

        // Assert
        Assert.AreEqual(-1, itemIndex);
    }
}