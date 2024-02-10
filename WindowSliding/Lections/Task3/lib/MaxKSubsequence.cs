namespace lib;

public static class MaxKSubsequence
{
    public static int[] GetMaxKSubsequence(int[] array, int k) {
        
        if (array.Length == 0) {
            return new int[0];
        }
        if (k > array.Length || k <= 0) {
            return new int[0];
        }
        
        List<int> deq = new(k);

        for (int i = 0; i < k - 1; i++) {
            AddToQueue(array[i], ref deq);
        }

        int[] result = new int[array.Length - k + 1];

        for (int i = k - 1; i < array.Length; i++)
        {
            AddToQueue(array[i], ref deq);
            result[i - k + 1] = deq[0];
            RemoveFromQueue(array[i - k + 1], ref deq);
        }
        return result;
    }

    private static void AddToQueue(int value, ref List<int> queue) {
        while(queue.Count > 0 && queue[^1] < value) {
            queue.RemoveAt(queue.Count - 1);
        }

        queue.Add(value);
    }

    private static void RemoveFromQueue(int value, ref List<int> queue) {
        if (queue.Count > 0 && queue[0] == value){
            queue.RemoveAt(0);
        }
    }
}
