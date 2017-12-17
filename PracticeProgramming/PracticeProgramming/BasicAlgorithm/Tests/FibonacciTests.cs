using NUnit.Framework;
using PracticeProgramming.BasicAlgorithm.Main;

namespace PracticeProgramming.BasicAlgorithm.Tests
{
    [TestFixture]
    public class FibonacciTests
    {
        private readonly long[] _fibonacciExpected =
            {
                1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584,
                4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229,
                832040, 1346269, 2178309, 3524578, 5702887, 9227465, 14930352, 24157817,
                39088169, 63245986, 102334155, 165580141, 267914296, 433494437, 701408733,
                1134903170, 1836311903, 2971215073, 4807526976, 7778742049, 12586269025
            };
        private readonly Fibonacci _fibonacci = new Fibonacci();

        #region FibonacciSequenceUpTo Tests

        [Test]
        public void FibonacciSequenceUpTo_Returns_Fibonacci_Sequence_Up_To_50_Digits()
        {
            const int count = 50;

            var actualSequence = _fibonacci.FibonacciSequenceUpTo(count);

            Assert.AreEqual(_fibonacciExpected, actualSequence);
        }

        [Test]
        public void FibonacciSequenceUpTo_Returns_Nothing_When_Count_Is_Zero()
        {
            const int count = 0;

            var actualSequence = _fibonacci.FibonacciSequenceUpTo(count);

            Assert.AreEqual(new long[0], actualSequence);
        }
        #endregion

        #region ValueAtIndex Tests



        #endregion

        #region SliceOfSequence Tests



        #endregion
    }
}
