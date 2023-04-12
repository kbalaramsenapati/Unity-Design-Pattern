namespace CommandPatterns.Calculator
{
    public interface ICommand
    {
        double Execute();
    }
    public class Invoker
    {
        public double ExecuteCommand(ICommand command)
        {
            return command.Execute();
        }
    }



    public class AddCommand : ICommand
    {
        private Calculator _calculator;

        public AddCommand(Calculator calculator)
        {
            _calculator = calculator;
        }

        public double Execute()
        {
            return _calculator.Add();
        }
    }
    public class SubCommand : ICommand
    {
        private Calculator _calculator;

        public SubCommand(Calculator calculator)
        {
            _calculator = calculator;
        }

        public double Execute()
        {
            return _calculator.Sub();
        }
    }
    public class MultiCommand : ICommand
    {
        private Calculator _calculator;

        public MultiCommand(Calculator calculator)
        {
            _calculator = calculator;
        }

        public double Execute()
        {
            return _calculator.Multi();
        }
    }
    public class DiviCommand : ICommand
    {
        private Calculator _calculator;

        public DiviCommand(Calculator calculator)
        {
            _calculator = calculator;
        }

        public double Execute()
        {
            return _calculator.Divi();
        }
    }
    public class PercentCommand : ICommand
    {
        private Calculator _calculator;

        public PercentCommand(Calculator calculator)
        {
            _calculator = calculator;
        }

        public double Execute()
        {
            return _calculator.Percent();
        }
    }
    public class OneDevidedxCommand : ICommand
    {
        private Calculator _calculator;

        public OneDevidedxCommand(Calculator calculator)
        {
            _calculator = calculator;
        }

        public double Execute()
        {
            return _calculator.OneDevidedx();
        }
    }
    public class xSqure : ICommand
    {
        private Calculator _calculator;

        public xSqure(Calculator calculator)
        {
            _calculator = calculator;
        }

        public double Execute()
        {
            return _calculator.xSqure();
        }
    }
    public class Sqrtx : ICommand
    {
        private Calculator _calculator;

        public Sqrtx(Calculator calculator)
        {
            _calculator = calculator;
        }

        public double Execute()
        {
            return _calculator.SqrtX();
        }
    }
    public class PluseMinuse : ICommand
    {
        private Calculator _calculator;

        public PluseMinuse(Calculator calculator)
        {
            _calculator = calculator;
        }

        public double Execute()
        {
            return _calculator.PluseMinuse();
        }
    }
}

