using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Basics;

namespace FunctionsTestProject
{
    [TestClass]
    public class FunctionsTest
    {
        /// <summary>
        /// Reverses the string test.
        /// </summary>
        [TestMethod]
        public void ReverseStringTest()
        {
            //Arrange
            var hello = "hello";
            var olleh = "olleh";
           
           
            // Act
            var reverseHello =  Functions.ReverseString(hello);

            // Assert
            Assert.AreEqual(olleh, reverseHello);
        }

        /// <summary>
        /// Calculates the NTH fibonacci number test.
        /// </summary>
        [TestMethod]
        public void CalculateNthFibonacciNumberTest()
        {
          // Fibo Algorithm
            

            // Arrange
            var oneOrZero = 1;
            var three = 3;
            var ten = 10;
           
            // Act
            var calculateFibo1 = Functions.CalculateNthFibonacciNumber(oneOrZero);
            var calculateFibo3 = Functions.CalculateNthFibonacciNumber(three);
            var calculateFibo10 = Functions.CalculateNthFibonacciNumber(ten);
          
            // Assert
            Assert.AreEqual(1, calculateFibo1);
            Assert.AreEqual(2, calculateFibo3);
            Assert.AreEqual(55, calculateFibo10);
        }


        /// <summary>
        /// Pads the number with zeroes test.
        /// </summary>
        [TestMethod]
        public void PadNumberWithZeroesTest()
        {
            // Arrange
            var one = 1;
            var three3 = 333;
            var four4 = 44;
            var nine9999 = 99999;
            // Act
            var pad333 = Functions.PadNumberWithZeroes(three3);
            var padOne = Functions.PadNumberWithZeroes(one);
            var pad4 = Functions.PadNumberWithZeroes(four4);
            var pad9999 = Functions.PadNumberWithZeroes(nine9999);
           
            // Assert
            Assert.AreEqual("00001", padOne);
            Assert.AreEqual("00333", pad333);
            Assert.AreEqual("00044", pad4);
            Assert.AreEqual("99999", pad9999);

        }

        /// <summary>
        /// Determines whether [is leap year test].
        /// </summary>
        [TestMethod]
        public void IsLeapYearTest()
        {
             // General A year is divided by 400 or is not divible by 100 and is divisible 4.

            // Arrange
            var twenty17 = 2017;
            var twenty00 = 2000;
            var twenty12 = 2012;
            var thisTrue = 1996;
            
            // Act
            var is2017LeapYear = Functions.IsLeapYear(twenty17);
            var is2012LeapYear = Functions.IsLeapYear(twenty12);
            var is2000LeapYear = Functions.IsLeapYear(twenty00);
            var is1996LeapYear = Functions.IsLeapYear(thisTrue);

            // Assert
            Assert.AreEqual(false, is2017LeapYear);
            Assert.AreEqual(true, is2012LeapYear);
            Assert.AreEqual(true, is2000LeapYear);
            Assert.AreEqual(true, is1996LeapYear);


        }

        /// <summary>
        /// Finds the NTH largest number test.
        /// </summary>
        [TestMethod]
        public void FindNthLargestNumberTest()
        {
            //Plan
                // We find the Nth largest by sorting the sequence first 
               // and then returning the element at position N-numberSupplied, which qualifies as the Nth largest element of the sequence.


            // Arrange
            List<int> numbers = new List<int>(){77 ,19 ,90 ,48, 29, 55, 2 ,53, 29, 7 ,19, 90 ,78, 21, 87 ,81 ,49, 53, 77, 1 };
            List<int> numberList = new List<int>() {2, 1,8};
            // Act
            var first = Functions.FindNthLargestNumber(numbers, 5);
            var sec = Functions.FindNthLargestNumber(numberList, 2);
            // Assert
            Assert.AreEqual(77, first);
            Assert.AreEqual(2, sec);
        }


        /// <summary>
        /// Selects the prime numbers test.
        /// </summary>
        [TestMethod]
        public void SelectPrimeNumbersTest()
        {
            //Plan: A prime is a natural number greater than 1 that has no positive divisors other than 1 and itself
              // High school concept, if number  is devisible by 2 and remain 1, OR if that number is 2, that is a prime number :)

            // Arrange
            var numberList = new List<int>() { 1, 2,3,5,6, 7 ,8,11, 12, 13, 14, 15, 16, 17,18, 19,20,21,22,23,24, 29,31, 33};
            var arePrimeNumbers = new List<int>(){ 2, 3, 5, 7, 11, 13,15,  17, 19,21, 23, 29, 31, 33 };

            var numberFew= new List<int>(){2,3,4,6, 101};
            var theyPrime= new List<int>(){2, 3,101};

            // Act

            var selectPrimeNumbers = Functions.SelectPrimeNumbers(numberList);
            var selectPrimeNumbers2 = Functions.SelectPrimeNumbers(numberFew);


            // Assert
            Assert.IsTrue(arePrimeNumbers.SequenceEqual(selectPrimeNumbers));
            Assert.IsTrue(theyPrime.SequenceEqual(selectPrimeNumbers2));

        }

        /// <summary>
        /// Determines whether [is palindrome test].
        /// </summary>
        [TestMethod]
        public void IsPalindromeTest()
        {

            // Arrange
            var numberPalindrome = 131;
            var notPalindrome = 21;

            // Act
            var checkIsTrue = Functions.IsPalindrome(numberPalindrome);
            var checkIsFalse = Functions.IsPalindrome(notPalindrome);


            // Assert
            Assert.AreEqual(true, checkIsTrue);
            Assert.AreEqual(false, checkIsFalse);
        }

        /// <summary>
        /// Counts the set bits test.
        /// </summary>
        [TestMethod]
        public void CountSetBitsTest()
        {
            // Arrange
            var number13 = 13;
            var num255 = 255;
             
            // Act
            var check3 = Functions.CountSetBits(number13);
            var check255 = Functions.CountSetBits(num255);

            // Assert
            Assert.AreEqual(3, check3);
            Assert.AreEqual(8, check255);
        }
    }
}
