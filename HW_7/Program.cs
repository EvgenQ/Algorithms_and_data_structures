using System;

namespace HW_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 5;
            int n = 5;
			int[,] field = new int[m, n];
			for (int j = 0; j < n; j++)
				field[0, j] = 1;
			for (int i = 1; i < m; i++)
			{
				field[i, 0] = 1;
				for (int j = 1; j < n; j++)
					field[i, j] = field[i, j - 1] + field[i - 1, j];
			}

			int padding = field[m - 1, n - 1].ToString().Length + 2;
			for (int i = 0; i < m; i++)
			{
				for (int j = 0; j < n; j++)
					Console.Write(field[i, j].ToString().PadLeft(padding));
				Console.WriteLine();
			}

		}
    }
}
