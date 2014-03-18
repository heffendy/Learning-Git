
namespace Scenario01
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
            return _value = _value.Decrement_NoNegative();
        }
    }

}
