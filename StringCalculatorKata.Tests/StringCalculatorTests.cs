using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculatorKata.App;

namespace StringCalculatorKata.Tests
{
    [TestClass]
    public class StringCalculatorTests
    {
        /*
         *  Prerequsites
         * 	    Visual Studio 2015
         *      .Net 4.5 or higher
         *      XUnit ----------------------> switched to us MSTest
         *      Core & Test projects
         *      Nuget
         *       
         *  Your Mission....
         *  -----------------
         *  
         *  Firstly restore all nuget packages
         *  
         *  Use TDD techniques to create a STRING CALCULATOR that takes a delimited set of numbers and returns the sum as the output.
         *  
         *  E.g. "10" = 10
         *       "2,4,9" = 15
         *       "2,4,9,5" =20
         *  
         *  Complete the mission by making the tests go GREEN one at a time!
         *  
         *  Remember the test class names describe the nature of the test, example of inputs is provided in the tests in notes.
         * 
         *  Aside from the standard functionality, if you have time try to:
         *    Allow any delimiter to be used, not just a comma
         *    Ignore any numbers more than 100
         *    Return 0 if a non numeric value is entered
         *    Throw a custom exception if the first 7 numbers match the Fibonacci Sequence
         *  
         *  DON'T WORRY if you can't complete all tests!
         * 
         *  The test uses the XUnit testing framework, please feel free to refer to the documentation @ https://xunit.github.io/
         */

        [TestMethod]
        public void Calculate_EmptyString_ReturnsZero()
        {
            //e.g. "" = 0

            // Arrange
            var expectedValue = 0;
            var calculator = new StringCalculator();

            // Act
            var returnedValue = calculator.Sum();

            // Assert
            Assert.AreEqual(expectedValue, returnedValue);
        }

        [TestMethod]
        public void Calculate_SingleNumber_ReturnsSameNumber()
        {
            //e.g. "1" = 1

            // Arrange
            var inputValue = "1";
            var expectedValue = 1;
            var calculator = new StringCalculator();

            // Act
            var returnedValue = calculator.Sum(inputValue);

            // Assert
            Assert.AreEqual(expectedValue, returnedValue);
        }

        [TestMethod]
        public void Calculate_TwoNumbers_ReturnsSum()
        {
            //e.g. "1,2" = 3

            // Arrange
            var inputValue = "1,2";
            var expectedValue = 3;
            var calculator = new StringCalculator();

            // Act
            var returnedValue = calculator.Sum(inputValue);

            // Assert
            Assert.AreEqual(expectedValue, returnedValue);
        }

        [TestMethod]
        public void Calculate_FiveNumbers_ReturnsSum()
        {
            //e.g. "1,2,3,4,5" = 15

            // Arrange
            var inputValue = "1,2,3,4,5";
            var expectedValue = 15;
            var calculator = new StringCalculator();

            // Act
            var returnedValue = calculator.Sum(inputValue);

            // Assert
            Assert.AreEqual(expectedValue, returnedValue);
        }

        //[Fact(Skip = "complete previous test first")]
        //public void Calculate_CanUseAlternativeDelimiters_ReturnsSum()
        //{
        //    //e.g. "1|2|3" = 6
        //}

        //[Fact(Skip = "complete previous test first")]
        //public void Calculate_NumbersLargerThan100_IgnoresOver100sInSum()
        //{
        //    //e.g. "1,2,100" = 3
        //}

        [TestMethod]
        public void Calculate_NonNumericValue_ReturnsZero()
        {
            //e.g. "1,Elephant,6" = 0
            // Arrange
            var inputValue = "1,Elephant,6";
            var expectedValue = 0;
            var calculator = new StringCalculator();

            // Act
            var returnedValue = calculator.Sum(inputValue);

            // Assert
            Assert.AreEqual(expectedValue, returnedValue);
        }

        //[Fact(Skip = "complete previous test first")]
        //public void Calculate_FirstSevenInFibonacciSequence_ThrowsCustomFibonacciAlertException()
        //{
        //    //e.g. "0,1,1,2,3,5,8" = FibonacciAlertException!
        //}
    }
}
