using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5
{
    class Ex4
    {

        internal static void ex4()
        {
            Console.WriteLine("Введите текст");
            String text = Console.ReadLine();
            char[] letters = new char[text.Length];
            int n = 0;
            foreach (char let in text)
            {
                letters[n] = let;
                n++;
            }
            int[] a = uni(letters);
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }

        }
        internal static int[] uni(char[] chars)
        {
            int[] b = new int[chars.Length];
            int i = 0;
            foreach (char ch in chars)
            {
                b[i] = (int)ch;
                i++;
            }
            return b;
        }

    }
}
