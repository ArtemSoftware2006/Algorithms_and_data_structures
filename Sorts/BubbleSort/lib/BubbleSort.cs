using System.Globalization;

namespace lib;

public static class BubbleSort
{
    public static int[] Sort(int[] array) {
        for (int i = 1; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int tmp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = tmp;
                }
            }
        }

        return array;
    }
}
