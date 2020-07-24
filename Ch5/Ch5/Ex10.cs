using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5
{
    class Ex10
    {
        internal static void ex10()
        {
            Console.WriteLine("Введите текст");
            string a = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Введите кол-во символов");
            int b = int.Parse(Console.ReadLine());
            char[] ar1 = new char[b];

            for (int i = 0; i < b; i++)
            {
                Console.Clear();
                Console.WriteLine("Введите произвольный символ");
                ar1[i] = char.Parse(Console.ReadLine());
            }
            Console.Clear();

            Console.WriteLine(Text(a, ar1));
        }

        internal static string Text(string text, params char[] chars)
        {
            foreach (char ch in chars)
            {
                text += Convert.ToString(ch);
            }
            return text;
        }
    }
}
