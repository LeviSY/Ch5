using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5
{
    class Ex8
    {
        internal static void ex8()
        {
        a:
            Console.Clear();
            Console.WriteLine("                 Выберите действие:               ");
            Console.WriteLine("==================================================");
            Console.WriteLine("1) Получить промежуточные значения между числами  ");
            Console.WriteLine("2) Получить промежуточные значения между символами");

            int a = int.Parse(Console.ReadLine());
            if (a <= 2 && a > 0)
            {
                if (a == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Введите 1-е число:");
                    int ft = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите 2-е число:");
                    int sd = int.Parse(Console.ReadLine());
                    Console.Clear();

                    int[] Ar1 = nums(ft, sd);

                    foreach (int i in Ar1)
                    {
                        Console.WriteLine(i);
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Введите 1-й символ:");
                    char ft = char.Parse(Console.ReadLine());
                    Console.WriteLine("Введите 2-й символ:");
                    char sd = char.Parse(Console.ReadLine());
                    Console.Clear();

                    char[] Ar2 = letters(ft, sd);

                    foreach (int c in Ar2)
                    {
                        Console.WriteLine((char)c);
                    }
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Неверное значение!");
                Console.ReadKey();
                goto a;
            }
        }
        internal static int[] nums(int x, int y)
        {
            int j = y - x + 1;
            int[] a1 = new int[j];
            for (int i = 0; i < j; i++)
            {
                a1[i] = x + i;
            }
            return a1;
        }


        internal static char[] letters(char x, char y)
        {
            int cX = (int)x;
            int cY = (int)y;

            int j = cY - cX + 1;
            char[] b1 = new char[j];

            for (int i = 0; i < j; i++)
            {
                b1[i] = (char)(cX + i);
            }
            return b1;
        }

    }
}
