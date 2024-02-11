namespace lib;

public static class CombinationSum
{
    public static IList<IList<int>> GetCombinationSum(int[] candidates, int target) {
        var result = new List<IList<int>>();
        var combination = new List<int>();
        calcCombination(ref candidates, ref target, 0, 0, combination, ref result);
        return result;
    }

    private static void calcCombination(ref int[] candidates, ref int target, int index, int sum, IList<int> combination, ref List<IList<int>> result) {

        if (sum == target)
        {
            result.Add(combination.ToArray());
            return;
        }
        while ( index < candidates.Length && sum < target) {
            combination.Add(candidates[index]);
            sum += candidates[index];
            calcCombination(ref candidates, ref target, index, sum, combination, ref result);
            sum -= candidates[index];
            combination.RemoveAt(combination.Count - 1);
            index++;
        }
    }
}
