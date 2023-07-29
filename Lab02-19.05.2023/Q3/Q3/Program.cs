using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle");
            float radius;
            radius = float.Parse(Console.ReadLine());

            Console.WriteLine($"area={radius * radius * Math.PI}\ncircumference={2 * radius * Math.PI}");
            Console.ReadLine();
        }
    }
}
