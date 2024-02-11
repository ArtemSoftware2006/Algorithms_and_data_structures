using lib;

namespace test;

public class CombinationSumTest
{
    [Fact]
    public void GetCombinationSum_BaseOcation_TwoCombinations()
    {
        int[] candidates = {2, 3, 6, 7};
        int target = 7; 

        List<IList<int>> expected = new List<IList<int>>()
        {
            new List<int>() {2, 2, 3},
            new List<int>() { 7 }
        };

        var result = CombinationSum.GetCombinationSum(candidates, target);

        expected.ForEach(x => Assert.Contains(x, result));
    }
}