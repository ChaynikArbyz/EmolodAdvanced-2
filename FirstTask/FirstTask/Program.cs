using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int[][] array = TwoDIntArrayHelper.CreateArray(10, 10);
            TwoDIntArrayHelper.RandomFillArray(array, 10, 100);

            TwoDIntArrayHelper.PrintArray("Масив випадкових чисел" ,array);

            Console.WriteLine("Сума чисел в діапазоні: " + TwoDIntArrayHelper.TrySumOfNumbersInRange(array));

        }
    }
}
