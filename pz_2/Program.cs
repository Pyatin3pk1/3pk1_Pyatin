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
