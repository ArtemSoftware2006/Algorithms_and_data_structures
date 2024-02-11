namespace lib;

public static class AllSubsets
{
    public static List<List<int>> GetAllSubsets(int[] array) {
        var result = new List<List<int>>();
        var subset = new List<int>();
        
        calcSubsets(ref array, ref subset, ref result);

        return result;
    }

    private static void calcSubsets(ref int[] array, ref List<int> subset, ref List<List<int>> result, int index = 0) {
        result.Add(subset);

        for (int i = index; i < array.Length; i++)
        {
            subset.Add(array[i]);

            calcSubsets(ref array, ref subset, ref result, i + 1);

            subset.RemoveAt(subset.Count - 1);
        }
    }
}
