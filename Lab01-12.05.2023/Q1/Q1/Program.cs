using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name:");
            string name=Console.ReadLine();
            Console.WriteLine("enter your batch:");
            float batch=float.Parse(Console.ReadLine());
            Console.WriteLine($"Name:{name}\nbatch:{batch}");
            Console.ReadLine();
        }
    }
}
