using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnowledgeCheck1_Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAdd()
        {
            // Arrange
            Calculator calculator = new Calculator();
            double first = 5;
            double second = 10;

            // Act
            double result = calculator.Calculate("add", first, second);

            // Assert
            Assert.AreEqual(15, result, "Addition result is incorrect");
        }

        [TestMethod]
        public void TestSubtract()
        {
            // Arrange
            Calculator calculator = new Calculator();
            double first = 10;
            double second = 5;

            // Act
            double result = calculator.Calculate("subtract", first, second);

            // Assert
            Assert.AreEqual(5, result, "Subtraction result is incorrect");
        }

        [TestMethod]
        public void TestMultiply()
        {
            // Arrange
            Calculator calculator = new Calculator();
            double first = 10;
            double second = 5;

            // Act
            double result = calculator.Calculate("multiply", first, second);

            // Assert
            Assert.AreEqual(50, result, "Multiplication result is incorrect");
        }
        [TestMethod]
        public void TestDivide()
        {
            // Arrange
            Calculator calculator = new Calculator();
            double first = 10;
            double second = 5;

            // Act
            double result = calculator.Calculate("divide", first, second);

            // Assert
            Assert.AreEqual((double)2, result, "Division result is incorrect");
        }
    }
}
