using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario03
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
            return _value = _value.Decrement();
        }
    }
}
