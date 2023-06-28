using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the salary:");
            float salary=float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the tax rate:");
            int tax_rate=int.Parse(Console.ReadLine());

            Console.WriteLine($"salary:{salary}\ntaxrate:{tax_rate}%");
            Console.ReadLine();

        }
    }
}
