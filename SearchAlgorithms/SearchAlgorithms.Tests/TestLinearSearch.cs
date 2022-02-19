using NUnit.Framework;

namespace SearchAlgorithms.Tests;

public class LinearSearchTests
{
    private LinearSearch _sut { get; set; }

    [SetUp]
    public void Init()
    {
        _sut = new LinearSearch();
    }

    [Test]
    public void Test_LinearSearch_ExistingItem()
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
    public void Test_LinearSearch_NotExistingItem()
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
    public void Test_LinearSearch_EmptyArray()
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
    public void Test_LinearSearch_NullArray()
    {
        // Arrange
        var itemToFind = 50;

        // Act
        var itemIndex = this._sut.Search(null, itemToFind);

        // Assert
        Assert.AreEqual(-1, itemIndex);
    }
}