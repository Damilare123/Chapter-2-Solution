﻿using System;

namespace Chapter_2_Solution_13
{
    class Program
    {
        static void Main(string[] args)
        {
            nt a = 2;
            int b = 3;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a:{0} b:{1}", a, b);
        }
    }
}
