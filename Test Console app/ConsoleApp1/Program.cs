﻿using System;

namespace xx
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double radius = 5;

            //your code goes here
            radius = Double.Parse(Console.ReadLine());
            double area = pi * (radius * radius);

            Console.WriteLine(area);

        }
    }
}
