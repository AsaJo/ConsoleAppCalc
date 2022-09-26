using ConsoleAppCalc.Models;

namespace ConsoleAppCalc.Tests.Models
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_SimpleValuesShouldCalculate()
        {
            // Arrange
            double expected = 5;
            // Act
            double actual = Calculator.Add(3, 2);
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Divide_DivideByZero()
        {
            // Arrange
            double expected = 0;
            // Act
            double actual = Calculator.Divide(15, 0);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 3, 7)]//[InlineData(double x + double y = double expected)]
        [InlineData(21, 5.25, 26.25)]
        [InlineData(-4, 3, -1)]
       
        public void Add_SimpleValuesShouldCalculate2(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Add(x, y);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}