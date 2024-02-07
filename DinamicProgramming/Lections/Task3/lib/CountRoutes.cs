namespace lib;

public static class CountRoutes
{
    public static int GetCountRoutes(int n, int m) {
        int[,] meshs = new int[n, m];
        meshs[0, 0] = 1;

        return CountForMesh(n - 1, m - 1 , ref meshs);
    }

    static int CountForMesh(int i, int j, ref int[,] meshs) {
        if (i < 0 || j < 0)
        {
            return 0;
        }
        if (meshs[i,j] != 0)
        {
            return meshs[i,j];
        }
        else 
        {
            meshs[i, j] = CountForMesh(i, j-1, ref meshs) + CountForMesh(i-1, j, ref meshs);
            return meshs[i, j]; 
        }
    }
}
