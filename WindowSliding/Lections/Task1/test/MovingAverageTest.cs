using lib;

namespace test;

public class MovingAverageTest
{
    [Fact]
    public void CalculateAverage_fiveValuesWindowThree_2_3_4()
    {
        double[] values = { 1, 2, 3, 4, 5 };
        int window = 3;

        double[] expected = {2, 3, 4};

        double[] result = MovingAverage.CalculateAverage(values, window);

        Assert.Equal(expected, result);
    }
}