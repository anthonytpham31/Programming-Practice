using System;

namespace PracticeProgramming.BasicAlgorithm.Main
{
    /// <summary>
    /// FizzBuzz is an old programming exercise.
    /// The goal is to iterate over a range of numbers and print a message about each number's divisibility.
    /// <p>
    /// The message is generated the following way:
    /// *) if the number is divisible by three, the message is `Fizz`
    /// *) if the number is divisible by five, the message is `Buzz`
    /// *) if the number is divisible by both three and five, the message is `FizzBuzz`
    /// *) otherwise, no message is produced
    /// <p>
    /// The exact message format for this assignment is specified in the `message(n)` method.
    /// </summary>
    public class SimpleFizzbuzz
    {
        /// <summary>
        /// Checks whether a given int `a` is evenly divisible by a given int `b` or not.
        /// For example, `CheckDivisibility(4, 2)` returns `true` and `CheckDivisibility(4, 3)` returns `false`.
        /// 
        /// @param a the number to be divided
        /// @param b the number to divide by
        /// @return `true` if a is evenly divisible by b, `false` otherwise
        /// @throws ArgumentException if b is zero
        /// </summary>
        public bool CheckDivisibility(int a, int b)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Generates a divisibility message for a given number.
        /// Returns original number if the given number is not divisible by 3 or 5.
        /// Message formatting examples:
        /// 1 -> 1 // not divisible by 3 or 5
        /// 9 -> "9: Fizz" // divisible by only 3
        /// 10 -> "10: Buzz" // divisible by only 5
        /// 15 -> "15: FizzBuzz" // divisible by both three and five
        /// 
        /// @param n the number to generate a message for
        /// @return a message according to the format above, or null if n is not divisible by either 3 or 5
        /// </summary>
        public string GetDivisibilityMessage(int number)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Generates an array of messages to print for a given range of numbers.
        /// If there is no message for an individual number (i.e., `message(n)` returns null),
        /// it should be excluded from the resulting array.
        ///
        /// @param start the number to start with (inclusive)
        /// @param end the number to end with (exclusive)
        /// @return an array of divisibility messages
        /// @throws ArgumentException if the given end is less than the given start
        /// </summary>
        public string[] GetDivisibilityMessagesAcrossRange(int start, int end)
        {
            throw new NotImplementedException();
        }
    }
}
