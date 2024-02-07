using System.Net.Http.Headers;

namespace lib;

public static class BinarySequence
{
    static Dictionary<int, int> _sequence = new();
    public static int GetSequenceWithoutDublicate(int n) {
        if (_sequence.ContainsKey(n))
        {
            return _sequence[n];
        }
        if (n < 2)
        {
            return 1;
        }
        else {
            int res = GetSequenceWithoutDublicate(n - 1) + GetSequenceWithoutDublicate(n - 2);
            _sequence[n] = res;
            return res;
        }
    }
}
