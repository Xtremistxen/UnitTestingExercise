using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            //Create a calculator object
            var calc = new Calculator();
            


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            var actual = calc.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 10, -5)]
        [InlineData(10, 3, 7)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var calc = new Calculator();
            
            //Act
            var actual = calc.Subtract(minuend, subtrhend);
            
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData( 9, 9, 81)]
        [InlineData(2, 2, 4)]

        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Arrange
            var calc = new Calculator();

            //Act
            var actual = calc.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(16, 8, 2)]
        [InlineData(81, 9, 9)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calc = new Calculator();

            //Act
            var actual = calc.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }
        

}
}
