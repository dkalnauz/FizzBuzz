﻿using System;

namespace MommyIKnowC
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0;
                ++i <= 100;
                Console.WriteLine("{0}{1}{2}", i % 3 == 0 ? "Fizz" : "", i % 5 == 0 ? "Buzz" : "", i % 3 != 0 && i % 5 != 0 ? i.ToString() : "")) ;
        }
    }
}
