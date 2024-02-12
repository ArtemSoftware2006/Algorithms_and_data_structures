using lib;

namespace test;

public class ShellSortTest
{
    [Fact]
    public void Sort_baseOcation_sortedArray()
    {
        int[] nums = [100, 2, 6, 7, 3, 12, -23, -4, 0, 24, 3, 1003];
        int[] expected = new int [nums.Length];

        Array.Copy(expected, nums, nums.Length);
        Array.Sort(expected);

        var result = ShellSort.Sort(nums);

        Assert.Equal(expected, result);
    }
}