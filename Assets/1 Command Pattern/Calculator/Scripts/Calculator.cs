
namespace CommandPatterns.Calculator
{
    public class Calculator
    {
        double _a, _b;
        public Calculator(double a, double b)
        {
            _a = a;
            _b = b;
        }
        public double Add()
        {
            return _a + _b;
        }
        public double Sub()
        {
            return _a - _b;
        }
        public double Multi()
        {
            return _a + _b;
        }
        public double Divi()
        {
            return _a / _b;
        }
        public double Percent()
        {
            return _b / 100;
        }
    }
}
