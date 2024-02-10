using lib;

namespace test;

public class MaxSubsequenceTest
{
    [Fact]
    public void GetMaxSubsequence_twoNumsMoreZero_1_2()
    {
        int[] nums = {1, 2};
        int[] expected = {1, 2};

        int[] result = MaxSubsequence.GetMaxSubsequence(nums);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetMaxSubsequence_fourNumsOneLessZero_4() {
        int[] nums = {1, 2, -3, 4};
        int[] expected = {4};

        int[] result = MaxSubsequence.GetMaxSubsequence(nums);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetMaxSubsequence_fourNumsOneLessZero_1_2() {
        int[] nums = {1, 2, -4, 4};
        int[] expected = {4};

        int[] result = MaxSubsequence.GetMaxSubsequence(nums);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetMaxSubsequence_sevenNumsOneLessZero_1_2() {
        int[] nums = {1, 2, -4, 4, 5, 6, -4};
        int[] expected = {4, 5, 6};

        int[] result = MaxSubsequence.GetMaxSubsequence(nums);

        Assert.Equal(expected, result);
    }
}