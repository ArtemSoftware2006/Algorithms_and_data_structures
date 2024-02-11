

// using var input = new StreamReader(Console.OpenStandardInput());
// using var output = new StreamWriter(Console.OpenStandardOutput());

// var s = input.ReadLine().Split();
// int a = int.Parse(s[0]);
// int b = int.Parse(s[1]);
// output.Write(a - b);

System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

using var input = new StreamReader(Console.OpenStandardInput());
using var output = new StreamWriter(Console.OpenStandardOutput());

var count = int.Parse(input.ReadLine());

for (int i = 0; i < count; i++)
{
    var s2 = input.ReadLine().Split();
    decimal countProducts = int.Parse(s2[0]);
    decimal procent = int.Parse(s2[1]);

    decimal sumKopik = 0.0m;

    for (int j = 0; j < countProducts; j++)
    {
        int price = int.Parse(input.ReadLine());

        decimal priceProc = decimal.Round(price * procent / 100, 2);
        priceProc = priceProc - Math.Truncate(priceProc);

        sumKopik += priceProc;
    }

    output.WriteLine(sumKopik.ToString("0.00"));
}

