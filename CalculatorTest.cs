using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add_Test()
        {
            //Arrange
            int expected = 10;
            int num1 = 6;
            int num2 = 4;
            //Act
            int actual = CalculatorLibrary.Calculator.Add(num1, num2);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_Test_FailMessage()
        {
            //Arrange
            int expected = 10;
            int num1 = 6;
            int num2 = 6;
            //Act
            int actual = CalculatorLibrary.Calculator.Add(num1, num2);
            //Assert
            Assert.AreEqual(expected, actual,"Test Case Failed");
        }
        [TestMethod]
        public void Add_Test_Double()
        {
            //Arrange
            double expected = 10.0;
            double num1 = 6.0;
            double num2 = 4.0;
            //Act
            double actual = CalculatorLibrary.Calculator.Add(num1, num2);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_Test_OverflowException()
        {
            //Arrange
            int num1 = int.MaxValue;
            int num2 = 4;
            //Act and Assert
            Assert.ThrowsException<System.OverflowException>(() => CalculatorLibrary.Calculator.Add(num1, num2));
        }
        [TestMethod]
        public void Add_Test_Double_OverflowException()
        {
            //Arrange
            double num1 = double.MaxValue;
            double num2 = 4.0;
            //Act and Assert
            Assert.ThrowsException<System.OverflowException>(() => CalculatorLibrary.Calculator.Add(num1, num2));
        }
        [TestMethod]
        public void Subtract_Test()
        {
            //Arrange
            int expected = 3;
            int num1 = 6;
            int num2 = 4;
            //Act
            int actual = CalculatorLibrary.Calculator.Subtract(num1, num2);
            //Assert
            Assert.AreEqual(expected, actual,1);
        }
        [TestMethod]
        public void Subtract_Test_Double()
        {
            //Arrange
            double expected = 2.0;
            double num1 = 6.0;
            double num2 = 4.0;
            //Act
            double actual = CalculatorLibrary.Calculator.Subtract(num1, num2);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiply_Test()
        {
            //Arrange
            int expected = 24;
            int num1 = 6;
            int num2 = 4;
            //Act
            int actual = CalculatorLibrary.Calculator.Multiply(num1, num2);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiply_Test_Double()
        {
            //Arrange
            double expected = 24.0;
            double num1 = 6.0;
            double num2 = 4.0;
            //Act
            double actual = CalculatorLibrary.Calculator.Multiply(num1, num2);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Divide_Test()
        {
            //Arrange
            int expected = 1;
            int num1 = 6;
            int num2 = 4;
            //Act
            int actual = CalculatorLibrary.Calculator.Divide(num1, num2);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Divide_Test_DivideByZeroException()
        {
            //Arrange
            int num1 = 6;
            int num2 = 0;
            //Act and Assert
            Assert.ThrowsException<System.DivideByZeroException>(() => CalculatorLibrary.Calculator.Divide(num1, num2));
        }
        [TestMethod]
        public void Divide_Test_Double()
        {
            //Arrange
            double expected = 1.5;
            double num1 = 6.0;
            double num2 = 4.0;
            //Act
            double actual = CalculatorLibrary.Calculator.Divide(num1, num2);
            //Assert
            Assert.AreEqual(expected, actual);
        }
       

    }
}
