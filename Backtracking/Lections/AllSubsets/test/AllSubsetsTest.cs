using lib;

namespace test;

public class AllSubsetsTest
{
    [Fact]
    public void Test1()
    {
        int[] array = {1,2,3};
        var expected = new List<List<int>>()
        {
            new List<int>() {},
            new List<int>() {1}, 
            new List<int>() { 2 }, 
            new List<int>() { 3 }, 
            new List<int>() { 1, 2 }, 
            new List<int>() { 1, 3 }, 
            new List<int>() { 2, 3 }, 
            new List<int>() { 1, 2, 3 }
        };    

        var result = AllSubsets.GetAllSubsets(array);

        expected.ForEach(x => Assert.Contains(x, result));
    }
}