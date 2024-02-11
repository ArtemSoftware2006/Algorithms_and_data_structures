
// using var input = new StreamReader(Console.OpenStandardInput());
// using var output = new StreamWriter(Console.OpenStandardOutput());

// var s = input.ReadLine().Split();
// int a = int.Parse(s[0]);
// int b = int.Parse(s[1]);
// output.Write(a - b);


using var input = new StreamReader(Console.OpenStandardInput());
using var output = new StreamWriter(Console.OpenStandardOutput());

var count = int.Parse(input.ReadLine());

for (int i = 0; i < count; i++)
{
    string str = input.ReadLine();

    if (str[0] != 'M')
    {
        output.WriteLine("NO");
        continue;
    }
    else {

        bool isRunToNext = true;

        for (int j = 1; j < str.Length && isRunToNext; j++)
        {
            char ch = str[j];

            switch (ch)
            {
                case 'M' : {
                    if (str[j - 1] != 'C' && str[j - 1] != 'D')
                    {   
                        output.WriteLine("NO");
                        isRunToNext = false;
                    }
                    break;
                }
                case 'R' : {
                    if (str[j - 1] != 'M')
                    {
                        output.WriteLine("NO");
                        isRunToNext = false;
                    }
                    break;
                }
                case 'C' : {
                    if (str[j - 1] != 'R')
                    {
                        output.WriteLine("NO");
                        isRunToNext = false;
                    } 
                    break;
                }
                case 'D' : {
                    if (str[j - 1] == 'D')
                    {
                        output.WriteLine("NO");
                        isRunToNext = false;
                    }
                    break;
                }   
            }
        }

        if (!isRunToNext)
        {
            continue;
        }

        if(str[^1] != 'D') {
            output.WriteLine("NO");
            continue;
        }
    }

    output.WriteLine("YES");
}