namespace lib;

public static class MaxSubsequence
{
    public static int[] GetMaxSubsequence(int[] array) {
        int curSum = array[0];
        int curSumLength = 1;
        int curSumIndex = 0;

        int maxSum = curSum;
        int maxSumLength = curSumLength;
        int maxSumStartIndex = curSumIndex;

        for (int i = 1; i < array.Length; i++)
        {
            if (curSum <= 0) {
                curSum = array[i];
                curSumIndex = i;
                curSumLength = 1;
            }
            else {
                curSum += array[i];
                curSumLength += 1;
            }
            if (curSum >= maxSum)
            {
                maxSum = curSum;
                maxSumStartIndex = curSumIndex;
                maxSumLength = curSumLength;
            }
        }
        int[] result = new int[maxSumLength];

        Array.Copy(array, maxSumStartIndex, result, 0, maxSumLength);

        return result;
    }
}
