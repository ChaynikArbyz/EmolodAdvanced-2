using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            char[] letters = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            char[] usedletters = new char[26];

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введіть щось на англійській щоб порахувати кількість літер");
            Console.ResetColor();

            string input = Console.ReadLine().Trim().ToLower();
            Console.WriteLine();


            for (int i = 0; i < input.Length; i++)
            {
            if (letters.Contains(input[i]) && !usedletters.Contains(input[i]))
                {
                        usedletters[i] = input[i];

                        Console.Write("Літерка ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(input[i]);
                        Console.ResetColor();
                        Console.Write(" зустрічається ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(input.Count(c => c == input[i]));
                        Console.ResetColor();
                        Console.Write(" разів\n");
                }

            }


        }
    }
}
