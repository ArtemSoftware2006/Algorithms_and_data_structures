using System.ComponentModel.DataAnnotations;

namespace lib;

public static class MovingAverage
{
    public static double[] CalculateAverage(double[] values, int windowSize) {
        double[] averages = new double[values.Length - windowSize + 1];
        double sum = 0;
        for (int i = 0; i < windowSize; i++)
        {
            sum += values[i];
            
        }

        averages[0] = sum / windowSize;

        for (int i = windowSize; i < values.Length; i++)
        {
            sum = sum - values[i - windowSize] + values[i];
            averages[i - windowSize + 1] = sum / windowSize; 
        }
        return averages;
    }
}
