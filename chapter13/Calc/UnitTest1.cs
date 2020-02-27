using System;
using Xunit;

namespace Calc
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var calculator = new MyCalculator();
            int result = calculator.Add(5, 8);
            Assert.Equal(13, result);
        }
    }
}
