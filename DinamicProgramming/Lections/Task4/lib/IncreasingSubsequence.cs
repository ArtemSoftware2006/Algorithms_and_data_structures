namespace lib;

public static class IncreasingSubsequence
{
    static int[] _indexesOnPrevious;
    static int[] _subsequenceLength;
    public static int[] GetMaxIncreasingSubsequence(int[] array) {

        _indexesOnPrevious = new int[array.Length];
        _subsequenceLength = new int[array.Length];

        _indexesOnPrevious[0] = 0;
        _subsequenceLength[0] = 1;

        GetMaxIncreasingSubsequence(ref array);

        int maxLength = _subsequenceLength.Max();
        int maxLengthIndex = Array.IndexOf(_subsequenceLength, maxLength);
        int[] result = new int[maxLength];

        result[maxLength - 1] = array[maxLengthIndex]; 

        for (int i = maxLength - 2; maxLengthIndex > 0; i--)
        {
            maxLengthIndex = _indexesOnPrevious[maxLengthIndex];
            result[i] = array[maxLengthIndex]; 
        }

        return result;
    }
    private static void GetMaxIncreasingSubsequence(ref int[] array, int k = 1) {

        if (k >= array.Length)
        {
            return;
        }

        for (int i = 0; i < k; i++)
        {
            if (array[i] < array[k])
            {
                _subsequenceLength[k] = _subsequenceLength[i] + 1;
                _indexesOnPrevious[k] = i;
            }
        }

        GetMaxIncreasingSubsequence(ref array, k + 1);
    }
}
