using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Basics
{
    public class Functions
    {
       
        /// <summary>
        /// Reverses a string.
        /// </summary>
        /// <param name="value">String to reverse.</param>
        /// <returns>Reversed string.</returns>
        public static string ReverseString(string value)
        {  var result = new StringBuilder();
            try
            {
                if (value.Length == 1){
                    return value;
                }
          
                char[] charArray = value.ToCharArray();
                for (int i = charArray.Length -1; i >= 0; i--)
                {
                    result.Append(charArray[i]);
                }

             return result.ToString();

            }
            catch (Exception e)
            {
              
                return "something went wrong" + e.ToString();
            }
          
        }

        /// <summary>
        /// Calculates the Nth fibonacci number.
        /// </summary>
        /// <param name="n">Fibonacci number to calculate.</param>
        /// <returns>The nth fibonacci number.</returns>
        public static int CalculateNthFibonacciNumber(int n)
        {
            var fibNumber = 1;
            try
            {
                 if (n == 1 ||n == 0) {
                      return fibNumber;
                 }
          
                 var previousFibNumber = 1;

                 for (int i = 2; i < n; i++) {
                         var temp = fibNumber;
                            fibNumber += previousFibNumber;
                            previousFibNumber = temp;
                 }

                 return fibNumber;
            }
            catch (Exception e)
            {
              return -1;
            }
        }

        /// <summary>
        /// Pads a number with up to four zeroes, returning a string with a total length of five numerical characters.
        /// </summary>
        /// <param name="number">Number to pad.</param>
        /// <returns>Zero-padded number.</returns>
        /// <remarks>Can only pad unsigned numbers up to 99999.</remarks>
        public static string PadNumberWithZeroes(int number)
        {
            var numberTotalChar = 5;
            StringBuilder sb = new StringBuilder();
           
            var result = "";
            try
            {
                Char[] numberToArray = number.ToString().ToCharArray();
                if (number <= 99999)
                {
                    if (numberToArray.Length <= numberTotalChar)
                    {

                        var minusTheLength = numberTotalChar - numberToArray.Length;
                        if (minusTheLength >= 1)
                        {
                            for (int i = 0; i < minusTheLength; i++)
                            {
                                sb.Append(0);
                            }
                        }
                        foreach (var item in numberToArray)
                        {
                            sb.Append(item);

                        }

                     return   result = sb.ToString();


                    }

                }
            }
            catch (Exception e)
            {
               return  e.ToString();
            }

            return null;
        }

        /// <summary>
        /// Determines if a year is a leap year.
        /// </summary>
        /// <param name="year">Year to determine.</param>
        /// <returns>True if leap year, false if not.</returns>
        public static bool IsLeapYear(int year)
        {
            //NOTE there is also other solution: We could use the .net struct DateTime
            // is .IsLeapYear method to determine if year is leap year or not
            try
            {

                if ((year % 400 == 0) || (year % 100 != 0 && year % 4 == 0))
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            catch (Exception e)
            {
               
                return  false;
            }

        }

        /// <summary>
        /// Find the N:th largest number in a range of numbers.
        /// </summary>
        /// <param name="numbers">List of integers.</param>
        /// <returns>The third largest number in list.</returns>
        public static int FindNthLargestNumber(List<int> numbers, int nthLargestNumber)
        {
            var numberToReturn = 0;
            try
            {
                numbers.Sort();
                var index = 0;
                while (index < numbers.Count - 1)
                {
                    if (numbers[index] == numbers[index + 1])
                        numbers.RemoveAt(index);
                    else
                        index++;
                }
                var result = numbers;
                result.ToArray();
               return numberToReturn = result[result.Count - (nthLargestNumber)];
            }
            catch (Exception e)
            {
                
                return 0;
            }
   
        }

        /// <summary>
        /// Selects all prime numbers from an enumerable with numbers.
        /// </summary>
        /// <param name="numbers">Enumerable with numbers.</param>
        /// <returns>An enumerable with only prime numbers.</returns>
        public static IEnumerable<int> SelectPrimeNumbers(IEnumerable<int> numbers)
        {
            var result = new List<int>();
            try
            {
                foreach (var number in numbers)
                {
                    if (number > 1)
                    {
                        if (number % 2 == 1 || number == 2)
                        {
                            result.Add(number);

                        }

                    }
                }
                return result.Distinct();
            }
            catch (Exception e)
            {
                return null;
            }

          
        }

        /// <summary>
        /// Determines if the bit pattern of value the same if you reverse it.
        /// </summary>
        /// <param name="value">Value to inspect.</param>
        /// <returns>True if the bit value is a palindrome otherwise false.</returns>
        public static bool IsPalindrome(int value)
        {
            try
            {
                // Converting int to string
                var convertIntString = Convert.ToString(value);

                StringBuilder sb = new StringBuilder();

                char[] charString = convertIntString.ToCharArray();

                for (int i = charString.Length - 1; i >= 0; i--)
                {
                    sb.Append(charString[i]);
                }

                // The reversed string  
                String reversed = sb.ToString();

                // Determine if it is true or false
                return convertIntString.Equals(reversed);
            }
            catch (Exception)
            {

                return false;
            }
          

        }

        /// <summary>
        /// Counts all set bits in an int value.
        /// </summary>
        /// <param name="value">Integer value to count bits in.</param>
        /// <returns>Number of set bits in integer value.</returns>
        public static int CountSetBits(int value)
        {
            try
            {
                  string convertToBinary = Convert.ToString(value, 2);

                    Char[] charArray = convertToBinary.ToCharArray();
                    StringBuilder sb = new StringBuilder();
                    foreach (var item in charArray)
                    {
                        if (item.ToString() == "1")
                        {
                            sb.Append(item);
                        }
                    }

                    return sb.Length;
            }
            catch (Exception)
            {

               return 0;
            }
           
        }
    }
}
