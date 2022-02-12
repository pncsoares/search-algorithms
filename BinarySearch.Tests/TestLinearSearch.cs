using NUnit.Framework;

namespace BinarySearch.Tests;

public class LinearSearchTests
{
    [Test]
    public void Test_LinearSearch_ExistingItem()
    {
        // Arrange
        var numbers = new int[] { 1, 5, 39, 0, 21, 3, 2, 38 };
        var itemToFind = 3;

        // Act
        var sut = new ArraySearch();
        var itemIndex = sut.LinearSearch(numbers, itemToFind);

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
        var sut = new ArraySearch();
        var itemIndex = sut.LinearSearch(numbers, itemToFind);

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
        var sut = new ArraySearch();
        var itemIndex = sut.LinearSearch(numbers, itemToFind);

        // Assert
        Assert.AreEqual(-1, itemIndex);
    }

    [Test]
    public void Test_LinearSearch_NullArray()
    {
        // Arrange
        int[] numbers = null;
        var itemToFind = 50;

        // Act
        var sut = new ArraySearch();
        var itemIndex = sut.LinearSearch(numbers, itemToFind);

        // Assert
        Assert.AreEqual(-1, itemIndex);
    }
}