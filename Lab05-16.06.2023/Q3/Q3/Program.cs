using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        int c = 0;
        static void Main(string[] args)
        {
            CalculateValues objCalulateValues=new CalculateValues();

            int num1;
            int num2;

            Console.WriteLine("Enter 1 for Addition\n Enter 2 for substraction\n Enter 3 for multiplication\n Enter 4 for division ");
            Console.WriteLine("Enter your choice:");
            int choice =int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a two number:");
            num1= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a two number:");
            num2= int.Parse(Console.ReadLine());

            switch (choice) 
            {
                case 1:
                    objCalulateValues.Addition(num1, num2);
                    Console.WriteLine("Enter your answer:" + c);

                    break;
                    case 2:
                    objCalulateValues.substraction(num1, num2);
                    Console.WriteLine("Enter your answer:"+ c);

                    break;
                    case 3:
                    objCalulateValues.Multiplication (num1, num2);

                    break; 
                    case 4:
                    objCalulateValues.Division(num1, num2);

                    break;
                    default:
                    Console.WriteLine("program Ends!");
                    break;
            }

            Console.WriteLine();
            Console.ReadLine();
           
        }
    }
}
