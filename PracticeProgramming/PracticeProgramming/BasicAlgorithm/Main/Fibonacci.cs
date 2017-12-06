using System;

namespace PracticeProgramming.BasicAlgorithm.Main
{
    /// The Fibonacci sequence is simply and recursively defined: the first two elements are `1`, and
    /// every other element is equal to the sum of its two preceding elements. For example:
    /// <p>
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
        /// @return the beginning of the fibonacci sequence, up to the given count, as an array of int elements
        /// @throws IllegalArgumentException if the given count is negative
        /// </summary>
        public int[] FibonacciSequenceUpTo(int count)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculates the value in the Fibonacci sequence at a given index. For example,
        /// `atIndex(0)` and `atIndex(1)` should return `1`, because the first two elements of the
        /// sequence are both `1`.
        /// 
        /// @param i the index of the element to calculate
        /// @return the calculated element
        /// @throws IllegalArgumentException if the given index is less than zero
        /// </summary>
        public int ValueAtIndex(int i)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculates the value in the Fibonacci sequence at a given index. For example,
        /// `atIndex(0)` and `atIndex(1)` should return `1`, because the first two elements of the
        /// sequence are both `1`.
        /// 
        /// @param i the index of the element to calculate
        /// @return the calculated element
        /// @throws IllegalArgumentException if the given index is less than zero
        /// </summary>
        public int[] SliceOfSequence(int start, int end)
        {
            throw new NotImplementedException();
        }
    }
}
