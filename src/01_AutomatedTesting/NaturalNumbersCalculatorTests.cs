using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _01_AutomatedTesting
{
    public class NaturalNumbersCalculatorTests
    {
        [Fact]
        public void AddMethod_Numbers_Success()
        {
            var calculator = new NaturalNumbersCalculator();
            var result = calculator.Add(1, 2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void SubtractMethod_Numbers_Success()
        {
            var calc = new NaturalNumbersCalculator();
            var result = calc.Subtract(5, 4);

            Assert.Equal(1,result);
        }

        [Fact]
        public void MultiplyMethod_Numbers_Success()
        {
            var calc = new NaturalNumbersCalculator();
            var result = calc.Multiply(5, 2);

            Assert.Equal(10, result);
        }

        [Fact]
        public void DivideMethod_Numbers_Success()
        {
            var calc = new NaturalNumbersCalculator();
            var result = calc.Divide(12, 6);

            Assert.Equal(2, result);
        }
    }
}
