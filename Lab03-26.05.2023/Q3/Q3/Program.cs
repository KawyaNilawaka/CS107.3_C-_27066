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
            Console.WriteLine("Enter a value:");
            int Num=int.Parse(Console.ReadLine());

            int sum = 0, Rem;
            while (Num>0)
            {
                Rem = Num % 10;
                sum += Rem;
                Num =Num/ 10;
            }
            Console.WriteLine("Sum:" + sum);
            Console.ReadLine();
        }
    }
}
