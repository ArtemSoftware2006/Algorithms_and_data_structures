using lib;

namespace test;

public class BubbleSortTest
{
    [Fact]
    public void Sort_baseOcation_sortedArray()
    {
        int[] nums = {10, 3, 15, 6, 0, -12, 88, 12, 70};

        var expected = new int[nums.Length];
        Array.Copy(nums, expected, nums.Length);
        Array.Sort(expected);

        var result = BubbleSort.Sort(nums);

        Assert.Equal(expected, result);
    }
}