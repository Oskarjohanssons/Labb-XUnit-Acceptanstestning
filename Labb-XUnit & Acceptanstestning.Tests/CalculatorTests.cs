namespace Labb_XUnit___Acceptanstestning.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void PerformAddition_AddsTwoNumbersCorrectly()
        {
            var calculator = new Calculator();
            double result = calculator.PerformAddition(5, 3);
            Assert.Equal(8, result);
        }

        [Fact]
        public void PerformSubtraction_SubtractsTwoNumbersCorrectly()
        {
            var calculator = new Calculator();
            double result = calculator.PerformSubtraction(10, 4);
            Assert.Equal(6, result);
        }

        [Fact]
        public void PerformMultiplication_MultipliesTwoNumbersCorrectly()
        {
            var calculator = new Calculator();
            double result = calculator.PerformMultiplication(2, 3);
            Assert.Equal(6, result);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(9, 3, 3)]
        [InlineData(15, 5, 3)]
        public void PerformDivision_DividesTwoNumbersCorrectly(double a, double b, double expected)
        {
            var calculator = new Calculator();
            double result = calculator.PerformDivision(a, b);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PerformDivision_ThrowsDivideByZeroException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.PerformDivision(10, 0));
        }

        [Fact]
        public void SaveCalculation_SavesCalculationCorrectly()
        {
            var calculator = new Calculator();
            calculator.PerformAddition(5, 3);
            var history = calculator.GetPreviousCalculations();
            Assert.Contains("5 + 3 = 8", history);
        }
    }
}