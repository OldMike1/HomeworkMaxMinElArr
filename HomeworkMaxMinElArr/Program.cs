using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMaxMinElArr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array");
            int x = int.Parse(Console.ReadLine());
            int[] array = new int[x];
            Random rnd = new Random();
            int Max = 0;
            int Min = 10;
            string IndexForMax = "";
            string IndexForMin = "";
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                if (Max <= array[i])
                    Max = array[i];

                if (Min >= array[i])
                    Min = array[i];
                
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (Max == array[i])
                    IndexForMax = IndexForMax + i + " ";

                if (Min == array[i])
                    IndexForMin = IndexForMin + i + " ";
            }
            Console.WriteLine($"Max = {Max} in positions {IndexForMax}");
            Console.WriteLine($"Min = {Min} in positions {IndexForMin}");
            int difference = Max - Min;
            Console.WriteLine($"difference = {difference}");
        }
    }
}
