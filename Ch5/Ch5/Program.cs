using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
        a:
            Console.Clear();
            menu.menu();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Exit")
                {
                    break;
                }
                switch (command)
                {
                    case "1":
                        {
                            Console.Clear();
                            Ex4.ex4();
                            Console.ReadKey();
                            goto a;
                        }
                    case "2":
                        {
                            Console.Clear();
                            Ex6.ex6();
                            Console.ReadKey();
                            goto a;
                        }
                    case "3":
                        {
                            Console.Clear();
                            Ex8.ex8();
                            Console.ReadKey();
                            goto a;
                        }
                    case "4":
                        {
                            Console.Clear();
                            Ex10.ex10();
                            Console.ReadKey();
                            goto a;
                        }
                }
            }

        }
    }
}
