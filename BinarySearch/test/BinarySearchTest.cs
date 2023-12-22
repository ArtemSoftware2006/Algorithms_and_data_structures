using app;

namespace test;

public class BinarySearchTest
{
    
    [Fact]
    public void FindIndex_Target7_Returns6()
    {
        BinarySearch<int> binarySearch = new BinarySearch<int>();
        int[] array = {1,2,3,4,5,6,7,8,9,10};
        int target = 7;
        int expected = 6;

        int result = binarySearch.FindIndex(array, target);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void FindIndex_Target100_ReturnsMinus1()
    {
        BinarySearch<int> binarySearch = new BinarySearch<int>();
        int[] array = {1,2,3,4,5,6,7,8,9,10};
        int target = 100;
        int expected = -1;

        int result = binarySearch.FindIndex(array, target);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void FindIndex_Target10_Returns9()
    {
        BinarySearch<int> binarySearch = new BinarySearch<int>();
        int[] array = {1,2,3,4,5,6,7,8,9,10};
        int target = 10;
        int expected = 9;

        int result = binarySearch.FindIndex(array, target);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void FindIndex_Target1_Returns0()
    {
        BinarySearch<int> binarySearch = new BinarySearch<int>();
        int[] array = {1,2,3,4,5,6,7,8,9,10};
        int target = 1;
        int expected = 0;

        int result = binarySearch.FindIndex(array, target);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void FindIndex_TargetString_d__Returns4()
    {
        BinarySearch<string> binarySearch = new BinarySearch<string>();
        string[] array = {"a", "b", "c", "d", "e", "f", "g", "h"};
        string target = "d";
        int expected = 3;

        int result = binarySearch.FindIndex(array, target);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void FindIndex_TargetString_abd__Returns1()
    {
        BinarySearch<string> binarySearch = new BinarySearch<string>();
        string[] array = {"abc", "abd", "acb", "acd", "adv"};
        string target = "abd";
        int expected = 1;

        int result = binarySearch.FindIndex(array, target);

        Assert.Equal(expected, result);
    }
}