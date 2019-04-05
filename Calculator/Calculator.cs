namespace CalculatorTests
{
    public class Calculator
    {
        private int _result;

        public void Add(int value)
        {
            _result += value;
        }

        public int GetSum()
        {
            return _result;
        }
    }
}