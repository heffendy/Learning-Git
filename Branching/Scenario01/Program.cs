﻿using System;

namespace Scenario01
{
    class Program
    {
        static void Main(string[] args)
        {
            Countdown countdown = new Countdown(5);

            Console.WriteLine(countdown.Decrement()); // 4
            Console.WriteLine(countdown.Decrement()); // 3
            Console.WriteLine(countdown.Decrement()); // 2
            Console.WriteLine(countdown.Decrement()); // 1
            Console.WriteLine(countdown.Decrement()); // 0

            // Negative tests
            Console.WriteLine(countdown.Decrement()); // 0
            Console.WriteLine(countdown.Decrement()); // 0

            Console.ReadLine();
        }
    }
}
