
internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 0; i < 40; i++)
        {
            Console.WriteLine(Task1.Fibacci.GetFib(i));   
        }
    }
}