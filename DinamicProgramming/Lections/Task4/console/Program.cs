using lib;

Console.WriteLine("Hello, World!");

int[] array =IncreasingSubsequence.GetMaxIncreasingSubsequence([2, 8, 5, 9, 12, 6, 13, 7, 8, 9]);

array.ToList().ForEach(x => Console.WriteLine(x));