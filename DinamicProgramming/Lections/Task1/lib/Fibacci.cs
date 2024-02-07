namespace Task1;

public static class Fibacci
{
    static Dictionary<int, int> _fib = new();
    public static int GetFib(int n) {
        if (_fib.ContainsKey(n))
        {
            return _fib[n];
        }
        if (n < 2) 
        {
            return 1;
        }
        else {
            int fib = GetFib(n - 1) + GetFib(n - 2); 
            _fib[n] = fib;
            return fib;
        }
    }
}
