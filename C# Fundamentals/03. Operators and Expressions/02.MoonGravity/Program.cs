﻿using System;

namespace _02.MoonGravity
{
    class Program
    {
        static void Main()
        {
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F3}", weight * 0.17);
        }
    }
}
