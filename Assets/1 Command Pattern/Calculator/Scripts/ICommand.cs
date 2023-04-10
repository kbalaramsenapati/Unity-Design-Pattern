namespace CommandPatterns.Calculator
{
    public interface ICommand
    {
        float Execute();
    }
    public class Invoker
    {
        public float ExecuteCommand(ICommand command)
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

        public float Execute()
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

        public float Execute()
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

        public float Execute()
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

        public float Execute()
        {
            return _calculator.Divi();
        }
    }
}
