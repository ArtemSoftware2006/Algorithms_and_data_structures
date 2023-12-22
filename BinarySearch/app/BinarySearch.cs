namespace app;
public class BinarySearch<T> where T : IComparable<T>
{
    public int FindIndex(T[] array, T target) 
    {
        int leftIndex = 0;
        int rigthIndex = array.Length - 1;

        while (leftIndex <= rigthIndex)
        {
            int middleIndex = leftIndex + (rigthIndex - leftIndex) / 2;

            if (target.CompareTo(array[middleIndex]) > 0)
            {
                leftIndex = middleIndex + 1;
            }
            else if (target.CompareTo(array[middleIndex]) < 0) 
            {
                rigthIndex = middleIndex - 1;
            }
            else 
            {
                return middleIndex;
            }
        }
        return -1;
    }
}
