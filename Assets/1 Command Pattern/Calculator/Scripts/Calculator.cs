
namespace CommandPatterns.Calculator
{
    public class Calculator
    {
        float _a, _b;
        public Calculator(float a, float b)
        {
            _a = a;
            _b = b;
        }
        public float Add()
        {
            return _a + _b;
        }
        public float Sub()
        {
            return _a - _b;
        }
        public float Multi()
        {
            return _a + _b;
        }
        public float Divi()
        {
            return _a / _b;
        }
    }
}
