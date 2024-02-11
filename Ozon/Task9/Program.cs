
using var input = new StreamReader(Console.OpenStandardInput());
using var output = new StreamWriter(Console.OpenStandardOutput());

var count = int.Parse(input.ReadLine());

for (int i = 0; i < count; i++)
{
    int countRequest = int.Parse(input.ReadLine());
    bool isOk = true;
    //                         x  y  z
    int[] firstPartRequest =  {0, 0, 0};

    string str = input.ReadLine();

    if (str[0] == 'Z')
    {
        output.WriteLine("NO");
        continue;
    }

    for (int j = 0; j < countRequest; j++)
    {
        char ch = str[j];

        if (ch == 'X') {
            firstPartRequest[0]++;
        } 
        else if (ch == 'Y') {
            if (firstPartRequest[0] > 0)
            {
                firstPartRequest[0] -= 1;
            } 
            else {
                firstPartRequest[1]++;
            }
        }
        else {
            if (firstPartRequest[1] > 0) {
                firstPartRequest[1] -= 1;
            }
            else if(firstPartRequest[0] > 0) {
                firstPartRequest[0] -= 1;
            }
            else {
                isOk = false;
                output.WriteLine("NO");
                break;
            }
        }
    }
    if (!isOk)
    {
        continue;
    }
    if (firstPartRequest[0] != 0 || firstPartRequest[1] != 0)
    {
        output.WriteLine("NO");
    }
    else {
        output.WriteLine("YES");
    }
}