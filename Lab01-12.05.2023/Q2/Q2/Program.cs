﻿using System;
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
            Console.WriteLine("Enter the radius of circle:");
            double radius=double.Parse(Console.ReadLine());

            double area;
            area = radius * radius * Math.PI;
            Console.WriteLine("area" + area);

            Console.ReadLine();
        }
    }
}
