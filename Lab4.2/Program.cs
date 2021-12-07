using System;

namespace Lab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.2 - средний - 8 вариант
            const int n = 3;
            const int m = 3;

            int[,] massive = new int[n, m];
            int i = 0, j, k = 0, p = 1;

            while (i < n * m) 
            {
                k++;
                for (j = k - 1; j < m - k + 1; j++)
                {
                    massive[k - 1, j] = p++;
                    i++;
                }  

                for (j = k; j < n - k + 1; j++)
                {
                    massive[j, m - k] = p++;
                    i++;
                }  

                for (j = m - k - 1; j >= k - 1; j--)
                {
                    massive[n - k, j] = p++;
                    i++;
                }  

                for (j = n - k - 1; j >= k; j--)
                {
                    massive[j, k - 1] = p++;
                    i++;
                }   

            }

            for (int q = 0; q < n; q++)
            {
                for (int w = 0; w < m; w++)

                    Console.Write(String.Format("{0,3}", massive[q, w]));
                Console.WriteLine();

            }
            Console.WriteLine();

        }

    }
    
}
