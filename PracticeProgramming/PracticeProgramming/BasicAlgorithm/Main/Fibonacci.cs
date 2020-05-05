using System;

namespace PracticeProgramming.BasicAlgorithm.Main
{
    /// The Fibonacci sequence is simply and recursively defined: the first two elements are `1`, and
    /// every other element is equal to the sum of its two preceding elements. For example:
    /// [1, 1] =>
    /// [1, 1, 1 + 1]  => [1, 1, 2] =>
    /// [1, 1, 2, 1 + 2] => [1, 1, 2, 3] =>
    /// [1, 1, 2, 3, 2 + 3] => [1, 1, 2, 3, 5] =>
    /// ...etc
    public class Fibonacci
    {
        /// <summary>
        /// Calculates the beginning of the fibonacci sequence, up to a given count.
        /// 
        /// @param count the number of elements to calculate
        /// @return the beginning of the fibonacci sequence, up to the given count, as an array of long elements
        /// @throws ArgumentException if the given count is negative
        /// </summary>
        public long[] FibonacciSequenceUpTo(int count)
        {
            long[] testVariable = new long[2] { 1,1};
            return testVariable;
        }

        /// <summary>
        /// Calculates the value in the Fibonacci sequence at a given index. For example,
        /// `ValueAtIndex(0)` and `ValueAtIndex(1)` should return `1`, because the first two elements of the
        /// sequence are both `1`.
        /// 
        /// @param i the index of the element to calculate
        /// @return the calculated element
        /// @throws ArgumentException if the given index is less than zero
        /// </summary>
        public long ValueAtIndex(int index)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculates a slice of the fibonacci sequence, starting from a given start index (inclusive) and
        /// ending at a given end index (exclusive).
        /// 
        /// @param start the starting index of the slice(inclusive)
        /// @param end   the ending index of the slice(exclusive)
        /// @return the calculated slice as an array of int elements
        /// @throws IllegalArgumentException if either the given start or end is negative, or if the
        ///     given end is less than the given start
        /// </summary>
        public long[] SliceOfSequence(int start, int end)
        {
            throw new NotImplementedException();
        }
    }
}
