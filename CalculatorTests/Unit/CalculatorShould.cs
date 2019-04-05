using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests.Unit
{
    [TestClass]
    public class CalculatorShould
    {
        private Calculator _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new Calculator();
        }
        
        [TestMethod]
        public void sum_two_positive_numbers()
        {
            _calculator.Add(1);     
            _calculator.Add(2);
            
            Assert.AreEqual(3, _calculator.GetSum());
        }

        [TestMethod]
        public void sum_two_negative_numbers()
        {
            _calculator.Add(-1);
            _calculator.Add(-2);
            
            Assert.AreEqual(-3, _calculator.GetSum());
        }

        [TestMethod]
        public void rollover_to_minvalue_when_maxvalue_exceeded()
        {
            _calculator.Add(int.MaxValue);
            _calculator.Add(1);
            
            Assert.AreEqual(int.MinValue, _calculator.GetSum());
        }
    }
}