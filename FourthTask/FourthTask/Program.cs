using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Random random = new Random(); 
            int[] numbers = new int[20];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(10, 100);
            }
            Console.WriteLine("масив чисел: ");

            foreach (int number in numbers)
            {
                Console.Write(number + ", ");
            }

            int[][] results = new int[numbers.Length - 2][];
            for (int i = 0; i < results.Length; i++)
            {
                results[i] = new int[4];
            }


            for (int i = 0; i < results.Length; i++)
            {
                for (int j = 0; j < results[i].Length; j++)
                {
                    results[i][0] = numbers[i] + numbers[i + 1] + numbers[i + 2];
                    results[i][1] = numbers[i];
                    results[i][2] = numbers[i + 1];
                    results[i][3] = numbers[i + 2];
                }
            }

            int firstPlace = 0;
            int secondPlace = 0;
            int thirdPlace = 0;

            for (int i = 0; i < results.Length; i++)
            {
                if (results[i][0] > firstPlace)
                {
                    thirdPlace = secondPlace;
                    secondPlace = firstPlace;
                    firstPlace = results[i][0];
                }
            }

            int firstPlaceI = 0;
            int secondPlaceI = 0;
            int thirdPlaceI = 0;

            for (int i = 0; i < results.Length; i++)
            {
                if (results[i][0] == firstPlace)
                {
                    firstPlaceI = i;
                }
                else if (results[i][0] == secondPlace)
                {
                    secondPlaceI = i;
                }
                else if (results[i][0] == thirdPlace)
                {
                    thirdPlaceI = i;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n--< Переможці з суми трьох сусідніх чисел масива >--");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n1 місце\nІндекс: {firstPlaceI} результат: {results[firstPlaceI][0]} числа: {results[firstPlaceI][1]}, {results[firstPlaceI][2]}, {results[firstPlaceI][3]}");
            Console.WriteLine($"\n2 місце\nІндекс: {secondPlaceI} результат: {results[secondPlaceI][0]} числа: {results[secondPlaceI][1]}, {results[secondPlaceI][2]}, {results[secondPlaceI][3]}");
            Console.WriteLine($"\n3 місце\nІндекс: {thirdPlaceI} результат: {results[thirdPlaceI][0]} числа: {results[thirdPlaceI][1]}, {results[thirdPlaceI][2]}, {results[thirdPlaceI][3]}");

        }
    }
}
