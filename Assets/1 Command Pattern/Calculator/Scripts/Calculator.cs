using System.Collections;
using UnityEngine;

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
        public Calculator(double a)
        {
            _a = a;
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
        public double OneDevidedx()
        {
            return 1 / _a;
        }
        public double xSqure()
        {
            return _a * _a;
        }
        public double SqrtX()
        {
            return Mathf.Sqrt((float)_a);
        }
        public double PluseMinuse()
        {
            return -_a;
        }

    }
}