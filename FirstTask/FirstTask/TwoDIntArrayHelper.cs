using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    internal static class TwoDIntArrayHelper
    {
        public static int[][] CreateArray(int x, int y)
        {
            if (x <= 0 || y <= 0)
            {
                Console.WriteLine("Розмір масива не може бути меньше нуля");
                return null;
            }
            else
            {
                int[][] array = new int[x][];
                for (int i = 0; i < x; i++)
                {
                    array[i] = new int[y];
                }
                return array;
            }
        }

        public static void RandomFillArray(int[][] array, int minInclude, int max)
        {
            if (array == null) { Console.WriteLine("Відсутній масив!"); }
            else 
            {
                Random rand = new Random();

                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        array[i][j] = rand.Next(minInclude, max);
                    }
                }
            }
        }

        internal static void bottomDecorator(int amountX)
        {
            Console.WriteLine("");
            for (int i = 0; i < amountX; i++)
            {
                Console.Write("------");
            }
            Console.WriteLine("");
        }

        public static void PrintArray(string arrayName,int[][] array)
        {
            Console.WriteLine("\t       --< " + arrayName + " >--");
            
            bottomDecorator(array.Length);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write("| " + array[i][j] + " |");
                }
            bottomDecorator(array.Length);
            }
        }

        public static int TrySumOfNumbersInRange(int[][] array)
        {
            if (array == null) { Console.WriteLine("Відсутній масив!"); return 0; }

            Console.WriteLine("Введіть діапазон пошуку чисел(включно) для суми задовольняючих чисел, також для їхньой суми кратній 5\nПерший діапазон: ");

            if (!int.TryParse(Console.ReadLine(), out int firstRange))
            {
                Console.WriteLine("Некоректне число ");
                return 0;
            }
            Console.WriteLine("Другий діапазон: ");
            if (!int.TryParse(Console.ReadLine(), out int secondRange))
            {
                Console.WriteLine("Некоректне число ");
                return 0;
            }

            if (firstRange > secondRange)
            {
                Console.WriteLine("Некоректний діапазон, перший діапазон не може бути більшим за другий");
                return 0;
            }
            int sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] >= firstRange && array[i][j] <= secondRange)
                    {
                        sum++;
                        if (array[i][j] % 5 == 0) { count++; }

                    }
                }
            }
            Console.WriteLine("\nСума чисел в діапазоні кратних 5: " + count);
            return sum;
        }
    }
}
