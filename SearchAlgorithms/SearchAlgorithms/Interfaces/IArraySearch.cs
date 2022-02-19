namespace SearchAlgorithms.Interfaces;

public interface IArraySearch
{
    /// <summary>
    /// Method to use linear search in the giving array
    /// </summary>
    /// <param name="array"></param>
    /// <param name="item"></param>
    /// <returns></returns>
    public int Search(int[] array, int item);
}