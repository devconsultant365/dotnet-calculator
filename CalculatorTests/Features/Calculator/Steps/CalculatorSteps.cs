using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace CalculatorTests.Features.Calculator.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly CalculatorTests.Calculator _calculator = new CalculatorTests.Calculator();
        private int result;

        [Given(@"I have a whole number of (.*)")]
        public void GivenIHaveAWholeNumberOf(int value)
        {
            _calculator.Add(value);
        }
        
        [When(@"I add the numbers together")]
        public void WhenIAddTheNumbersTogether()
        {
            result = _calculator.GetSum();
        }
        

        [Then(@"The resulting number should be (.*)")]
        public void ThenTheResultingNumberShouldBe(int expected)
        {
            Assert.AreEqual(expected, result);
        }
    }
}