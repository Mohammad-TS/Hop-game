using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizz_buzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("hop 3 ");
                    Console.ResetColor();
                }
                if (i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("hop 5 ");
                    Console.ResetColor();
                }
                if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();


        }
    }
}
