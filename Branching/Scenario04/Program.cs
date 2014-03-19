using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario04
{
    class Program
    {
        class Countdown
        {
            private int _value = 0;

            public Countdown(int value)
            {
                _value = value;
            }

            public int Decrement()
            {
                return --_value;
            }
        }

        static void Main(string[] args)
        {
            Countdown countdown = new Countdown(5);

            Console.WriteLine(countdown.Decrement()); // 4
            Console.WriteLine(countdown.Decrement()); // 3
            Console.WriteLine(countdown.Decrement()); // 2
            Console.WriteLine(countdown.Decrement()); // 1
            Console.WriteLine(countdown.Decrement()); // 0

            Console.ReadLine();
        }
    }
}
