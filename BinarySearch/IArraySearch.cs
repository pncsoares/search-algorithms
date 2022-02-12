public interface IArraySearch
{
    /// <summary>
    /// Method to use linear search in the giving array
    /// </summary>
    /// <param name="array"></param>
    /// <param name="item"></param>
    /// <returns></returns>
    public int LinearSearch(int[] array, int item);

    /// <summary>
    /// Method to use binary search via while loop in the giving array
    /// </summary>
    /// <param name="array"></param>
    /// <param name="item"></param>
    /// <returns></returns>
    public int BinarySearch(int[] array, int item);

    /// <summary>
    /// Method to use linear search recursiverly in the giving array
    /// </summary>
    /// <param name="array"></param>
    /// <param name="item"></param>
    /// <returns></returns>
    public int BinarySearchRecursive(int[] array, int item);
}