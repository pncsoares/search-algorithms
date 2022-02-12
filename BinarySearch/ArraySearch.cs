namespace BinarySearch;

public class ArraySearch : IArraySearch
{
    public int LinearSearch(int[] array, int item)
    {
        if (array == null)
        {
            return -1;
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == item)
            {
                return i;
            }
        }

        // you must pass -1 because array starts in zero
        // zero is a valid position and represents the beginning of the array
        return -1; 
    }

    public int BinarySearch(int[] array, int item)
    {
        if (array == null)
        {
            return -1;
        }

        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int middle = (left + right) / 2;

            if (array[middle] == item)
            {
                return middle;
            }

            if (item < array[middle])
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }

        return -1;
    }

    public int BinarySearchRecursive(int[] array, int item)
    {
        if (array == null)
        {
            return -1;
        }
        
        return BinarySearchRecursive(array, 0, array.Length - 1, item);
    }

    private int BinarySearchRecursive(int[] array, int left, int right, int item)
    {
        if (left <= right)
        {
            int middle = left + (right - left) / 2;

            if (array[middle] == item)
            {
                return middle;
            }

            if (item < array[middle])
            {
                return BinarySearchRecursive(array, left, middle - 1, item);
            }
            else
            {
                return BinarySearchRecursive(array, middle + 1, right, item);
            }
        }

        return -1;
    }
}