using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 numbers");
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numbers[i]=int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                if (numbers[i]%2==0)
                {
                    Console.WriteLine($"{numbers[i]} is an even number.")
                }
                else
                {
                    Console.WriteLine($"{numbers[i]} is an odd number.")
                }
            }
            Console.ReadLine();
        }
    }
}
