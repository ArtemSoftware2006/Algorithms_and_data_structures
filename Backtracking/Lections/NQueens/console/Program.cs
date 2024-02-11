class Program
{
    static int N = 5;
    static int[,] board = new int[N, N];

    static bool IsSafe(int row, int col)
    {
        int i, j;

        for (i = 0; i < col; i++)
            if (board[row, i] == 1)
                return false;

        for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
            if (board[i, j] == 1)
                return false;

        for (i = row, j = col; j >= 0 && i < N; i++, j--)
            if (board[i, j] == 1)
                return false;

        return true;
    }

    static void SolveNQUtil(int col)
    {
        if (col >= N)
        {
            PrintSolution();
            Console.WriteLine();
            return;
        }

        for (int i = 0; i < N; i++)
        {
            if (IsSafe(i, col))
            {
                board[i, col] = 1;

                SolveNQUtil(col + 1);

                board[i, col] = 0; // BACKTRACK
            }
        }
    }

    static void SolveNQ()
    {
        SolveNQUtil(0);
    }

    static void PrintSolution()
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
                Console.Write(" " + board[i, j] + " ");
            Console.WriteLine();
        }
    }

    static void Main()
    {
        SolveNQ();
    }
}