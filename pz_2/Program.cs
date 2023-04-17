using System;
using System.Drawing;
using System.Numerics;
using System.Runtime;

namespace pz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[,] a = new int[,]
            {
               {0, 1, 1, 0, 0}, 
               {0, 0, 0, 1, 0},
               {0, 1, 0, 0, 1},
               {0, 0, 1, 0, 0},
               {0, 0, 0, 1, 0}
            };
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) { a[i, j] = 1; }

                    if (a[i, j] != 1)
                    {
                        for (int k = 0; k < n; k++)
                        {
                            if (j != 0)
                            {
                                if (a[j, j - 1] == 1)
                                {
                                    a[i, j] = 1;
                                }
                                else
                                {
                                    if (a[k, j] == 1) a[k, j] = 1;
                                    else
                                    {
                                        if (a[k, i - 1] == 1) a[i, j] = 1;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        
                        a[i, k] = a[k, j];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }

           
        
            

        }
    }
    
}
