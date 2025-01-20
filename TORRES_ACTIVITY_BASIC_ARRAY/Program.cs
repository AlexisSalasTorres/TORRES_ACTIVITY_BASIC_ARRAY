using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TORRES_ACTIVITY_BASIC_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do you want to process?");
            int count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = numbers.Sum();
            int largest = numbers.Max();
            int smallest = numbers.Min();

            Console.WriteLine($"Sum of all numbers: {sum}");
            Console.WriteLine($"Largest number: {largest}");
            Console.WriteLine($"Smallest number: {smallest}");
            Console.ReadLine();

           


        }
    }
}
