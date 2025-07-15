using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Random random = new Random();
            int[] array = new int[100];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100, 901);
            }

            int lesslessnum = 900;
            int secondlessnum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < lesslessnum)
                {
                    secondlessnum = lesslessnum;
                    lesslessnum = array[i];
                }
            }

            //коду може бути в 2 рази меньше, але з декором виходить так
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Массив випадкових чисел від 100 до 900:");
            Console.ResetColor();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == lesslessnum)
                { 
                Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(array[i] + ", ");
                    Console.ResetColor();
                }
                else if (array[i] == secondlessnum)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(array[i] + ", ");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(array[i] + ", ");
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nНайменше число в масиві: " + lesslessnum);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Друге найменше число в масиві: " + secondlessnum);
            Console.ResetColor();
        }
    }
}
