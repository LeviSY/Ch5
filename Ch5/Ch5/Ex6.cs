using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5
{
    class Ex6
    {
        internal static void ex6()
        {
            Console.WriteLine("Введите длину массивов");
            int n = int.Parse(Console.ReadLine());
            int[] Ar1 = new int[n];
            int[] Ar2 = new int[n];
            Console.Clear();

            for (int i = 0; i < Ar1.Length; i++)
            {
                Console.WriteLine("Введите элемент " + i + "-й первого массива ");
                Ar1[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();

            for (int i = 0; i < Ar2.Length; i++)
            {
                Console.WriteLine("Введите элемент " + i + "-ы второго массива");
                Ar2[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();

            int[,] SqAr;
            SqAr = new int[2, n];

            for (int i = 0; i < Ar1.Length; i++)
            {
                SqAr[0, i] = Ar1[i];
            }
            for (int i = 0; i < Ar2.Length; i++)
            {
                SqAr[1, i] = Ar2[i];
            }


            int a = maxnum(SqAr);
            Console.WriteLine(a);
        }

        internal static int maxnum(int[,] b, int x = 0, int y = 0)
        {
            int max = 0;
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int k = 0; k < b.GetLength(1); k++)
                {
                    if (b[i, k] > max)
                    {
                        max = b[i, k];
                        x = i;
                        y = k;
                    }
                }
            }
            return max;
        }
    }
}
