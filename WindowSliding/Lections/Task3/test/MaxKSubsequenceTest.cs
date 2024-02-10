using lib;

namespace test;

public class MaxKSubsequenceTest
{
    [Fact]
    public void GetMaxKSubsequence_threeNums_1_2_3()
    {
        int[] nums = {1,2,3};
        int k = 1;

        int[] expect = {1,2,3};

        int[] result = MaxKSubsequence.GetMaxKSubsequence(nums, k);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void GetMaxKSubsequence_threeNums_k_sThree_3()
    {
        int[] nums = {1,2,3};
        int k = 3;

        int[] expect = {3};

        int[] result = MaxKSubsequence.GetMaxKSubsequence(nums, k);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void GetMaxKSubsequence_threeNums_k_sZero_emptyArray()
    {
        int[] nums = {1,2,3};
        int k = 0;

        int[] expect = {};

        int[] result = MaxKSubsequence.GetMaxKSubsequence(nums, k);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void GetMaxKSubsequence_threeNums_k_sFour_emptyArray()
    {
        int[] nums = {1,2,3};
        int k = 4;

        int[] expect = {};

        int[] result = MaxKSubsequence.GetMaxKSubsequence(nums, k);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void GetMaxKSubsequence_zeroNums_emptyArray()
    {
        int[] nums = {};
        int k = 4;

        int[] expect = {};

        int[] result = MaxKSubsequence.GetMaxKSubsequence(nums, k);

        Assert.Equal(expect, result);
    }
}