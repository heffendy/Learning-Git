using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario01
{
    static class IntExtensions
    {
        public static int Decrement(this int value)
        {
            return --value;
        }
    }
}
