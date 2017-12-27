using NUnit.Framework;
using PracticeProgramming.BasicAlgorithm.Main;
using System.Linq;

namespace PracticeProgramming.BasicAlgorithm.Tests
{
    [TestFixture]
    public class FibonacciTests
    {
        #region Test Variables

        private readonly long[] _fibonacciExpected =
            {
                1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584,
                4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229,
                832040, 1346269, 2178309, 3524578, 5702887, 9227465, 14930352, 24157817,
                39088169, 63245986, 102334155, 165580141, 267914296, 433494437, 701408733,
                1134903170, 1836311903, 2971215073, 4807526976, 7778742049, 12586269025
            };
        private readonly Fibonacci _fibonacci = new Fibonacci();
        #endregion

        #region FibonacciSequenceUpTo Tests

        [Test]
        [Category("Fibonacci Sequence")]
        public void FibonacciSequenceUpTo_Returns_Fibonacci_Sequence_Up_To_50_Digits()
        {
            const int count = 50;

            var actualSequence = _fibonacci.FibonacciSequenceUpTo(count);

            Assert.AreEqual(_fibonacciExpected, actualSequence);
        }

        [Test]
        [Category("Fibonacci Sequence")]
        public void FibonacciSequenceUpTo_Returns_Nothing_When_Count_Is_Zero()
        {
            const int count = 0;

            var actualSequence = _fibonacci.FibonacciSequenceUpTo(count);

            Assert.AreEqual(new long[0], actualSequence);
        }

        [Test]
        [Category("Fibonacci Sequence")]
        public void FibonacciSequenceUpTo_Returns_One_When_Count_Is_One()
        {
            const int count = 1;

            var actualSequence = _fibonacci.FibonacciSequenceUpTo(count);

            Assert.AreEqual(new long[] { 1 }, actualSequence);
        }

        [Test]
        [Category("Fibonacci Sequence")]
        public void FibonacciSequenceUpTo_Returns_One_One_When_Count_Is_Two()
        {
            const int count = 2;

            var actualSequence = _fibonacci.FibonacciSequenceUpTo(count);

            Assert.AreEqual(new long[] { 1, 1 }, actualSequence);
        }

        [Test]
        [Category("Fibonacci Sequence")]
        public void FibonacciSequenceUpTo_Throws_ArgumentException_When_Count_Is_Negative()
        {
            const int count = -1;

            Assert.That(() => _fibonacci.FibonacciSequenceUpTo(count), Throws.ArgumentException);
        }
        #endregion

        #region ValueAtIndex Tests

        [Test]
        [Category("Fibonacci Values")]
        public void ValueAtIndex_Returns_One_When_Index_Is_Zero()
        {
            const int index = 0;

            var value = _fibonacci.ValueAtIndex(index);

            Assert.AreEqual(_fibonacciExpected[index], value);
        }

        [Test]
        [Category("Fibonacci Values")]
        public void ValueAtIndex_Returns_One_When_Index_Is_One()
        {
            const int index = 1;

            var value = _fibonacci.ValueAtIndex(index);

            Assert.AreEqual(_fibonacciExpected[index], value);
        }

        [Test]
        [Category("Fibonacci Values")]
        public void ValueAtIndex_Returns_Correct_Value_Up_To_50_Iterations()
        {
            var index = 0;

            for (int i = index; i <= _fibonacciExpected.Length; i++)
            {
                var value = _fibonacci.ValueAtIndex(index);

                Assert.AreEqual(_fibonacciExpected[index], value);
            }
        }

        [Test]
        [Category("Fibonacci Values")]
        public void ValueAtIndex_Throws_ArgumentException_When_Index_Is_Negative()
        {
            const int index = -1;

            Assert.That(() => _fibonacci.ValueAtIndex(index), Throws.ArgumentException);
        }
        #endregion

        #region SliceOfSequence Tests

        [Test]
        [Category("Fibonacci Slice")]
        public void SliceOfSequence_Returns_Correct_Slices_For_Any_Range()
        {
            var start = 0;
            var end = 5;

            for (int i = start; end <= _fibonacciExpected.Length; i++)
            {
                var slice = _fibonacci.SliceOfSequence(start, end);
                var expectedSlice = _fibonacciExpected.Skip(start)
                                                      .Take(end - start)
                                                      .ToArray();

                Assert.AreEqual(expectedSlice, slice);
                start++;
                end++;
            }
        }

        [Test]
        [Category("Fibonacci Slice")]
        public void SliceOfSequence_Returns_Empty_Array_When_Start_And_End_Is_Zero()
        {
            const int start = 0;
            const int end = 0;

            var slice = _fibonacci.SliceOfSequence(start, end);

            Assert.AreEqual(new long[0], slice);
        }

        [Test]
        [Category("Fibonacci Slice")]
        public void SliceOfSequence_Throws_Argument_Exception_When_Start_Is_Negative()
        {
            const int start = -1;
            const int end = 1;

            Assert.That(() => _fibonacci.SliceOfSequence(start, end), Throws.ArgumentException);
        }

        [Test]
        [Category("Fibonacci Slice")]
        public void SliceOfSequence_Throws_Argument_Exception_When_End_Is_Negative()
        {
            const int start = -2;
            const int end = -1;

            Assert.That(() => _fibonacci.SliceOfSequence(start, end), Throws.ArgumentException);
        }

        [Test]
        [Category("Fibonacci Slice")]
        public void SliceOfSequence_Throws_Argument_Exception_When_End_Is_Less_Than_Start()
        {
            const int start = 1;
            const int end = 0;

            Assert.That(() => _fibonacci.SliceOfSequence(start, end), Throws.ArgumentException);
        }
        #endregion
    }
}
