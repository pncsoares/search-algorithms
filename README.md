# Binary Search in C#

This repository aims to create a binary search algorithm in C#.

# Technologies

- [.Net Core](https://dotnet.microsoft.com/en-us/download)
- [.Net CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/)
- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)

# Setup

## Clone repository

Create and go to the directory where you want to place the repository

```bash
  cd my-directory
```

Clone the project

```bash
  git clone PUT_ADDRESS_HERE
```

Go to the project directory

```bash
  cd binary-search
```

Open in Visual Studio Code

```bash
  code .
```

## Build

```bash
  dotnet build BinarySearch
```

## Execute tests

```bash
  dotnet test BinarySearch.Tests
```

# How binary search works

> **_NOTE:_** The array must be ordered otherwise you'll not be able to apply this algorithm. If it's not, you must order it using f.e.: `Array.Sort`

Binary Search is a searching algorithm used in a sorted array by repeatedly dividing the search interval in half. The idea of binary search is to use the information that the array is sorted and reduce the time complexity to O(Log n). The basic steps to perform Binary Search are:

Begin with an interval covering the whole array. 
If the value of the search key is less than the item in the middle of the interval, narrow the interval to the lower half. 
Otherwise, narrow it to the upper half. 
Repeatedly check until the value is found or the interval is empty.

We basically ignore half of the elements just after one comparison:
1. Compare x with the middle element;
1. If x matches with the middle element, we return the mid index;
1. Else If x is greater than the mid element, then x can only lie in the right half subarray after the mid element. So we recur for the right half;
1. Else (x is smaller) recur for the left half;

# License

MIT