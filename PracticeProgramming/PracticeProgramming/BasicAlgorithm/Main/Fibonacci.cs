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
        /// @throws IllegalArgumentException if the given count is negative
        /// </summary>
        public long[] FibonacciSequenceUpTo(int count)
        {
            var fibonacci = new long[count];

            switch (count)
            {
                case 0:
                    break;
                case 1:
                    fibonacci[0] = 1;
                    break;
                case 2:
                    fibonacci[0] = fibonacci[1] = 1;
                    break;
                default:
                    fibonacci[0] = fibonacci[1] = 1;

                    for (var i = 2; i < count; i++)
                    {
                        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                    }
                    break;
            }

            return fibonacci;
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
        public long ValueAtIndex(int i)
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
        public long[] SliceOfSequence(int start, int end)
        {
            throw new NotImplementedException();
        }

        public Fibonacci()
        {

        }
    }
}
