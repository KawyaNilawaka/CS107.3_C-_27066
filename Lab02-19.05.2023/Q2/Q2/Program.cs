using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num1:");
            int num1=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the num2:");
            int num2=int.Parse(Console.ReadLine());
            Console.WriteLine($"sum={num1 + num2}\nsubstraction={num1 - num2}\ndivision={num1 / num2}\nmultiplication={num1 * num2}");

           
            Console.ReadLine();
        }
    }
}
