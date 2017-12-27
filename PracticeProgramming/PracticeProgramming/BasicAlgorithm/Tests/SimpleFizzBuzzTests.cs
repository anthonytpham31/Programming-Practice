using NUnit.Framework;
using PracticeProgramming.BasicAlgorithm.Main;
using System.Linq;

namespace PracticeProgramming.BasicAlgorithm.Tests
{
    [TestFixture]
    public class SimpleFizzBuzzTests
    {
        #region Test Variables

        private readonly string[] _fizzBuzzExpected =
            {
                "-100: Buzz", "-99: Fizz", "-98", "-97", "-96: Fizz", "-95: Buzz", "-94", "-93: Fizz", "-92", "-91",
                "-90: FizzBuzz", "-89", "-88", "-87: Fizz", "-86", "-85: Buzz", "-84: Fizz", "-83", "-82", "-81: Fizz",
                "-80: Buzz", "-79", "-78: Fizz", "-77", "-76", "-75: FizzBuzz", "-74", "-73", "-72: Fizz", "-71",
                "-70: Buzz", "-69: Fizz", "-68", "-67", "-66: Fizz", "-65: Buzz", "-64", "-63: Fizz", "-62", "-61",
                "-60: FizzBuzz", "-59", "-58", "-57: Fizz", "-56", "-55: Buzz", "-54: Fizz", "-53", "-52", "-51: Fizz",
                "-50: Buzz", "-49", "-48: Fizz", "-47", "-46", "-45: FizzBuzz", "-44", "-43", "-42: Fizz", "-41",
                "-40: Buzz", "-39: Fizz", "-38", "-37", "-36: Fizz", "-35: Buzz", "-34", "-33: Fizz", "-32", "-31",
                "-30: FizzBuzz", "-29", "-28", "-27: Fizz", "-26", "-25: Buzz", "-24: Fizz", "-23", "-22", "-21: Fizz",
                "-20: Buzz", "-19", "-18: Fizz", "-17", "-16", "-15: FizzBuzz", "-14", "-13", "-12: Fizz", "-11",
                "-10: Buzz", "-9: Fizz", "-8", "-7", "-6: Fizz", "-5: Buzz", "-4", "-3: Fizz", "-2", "-1",
                "0: FizzBuzz", "1", "2", "3: Fizz", "4", "5: Buzz", "6: Fizz", "7", "8", "9: Fizz",
                "10: Buzz", "11", "12: Fizz", "13", "14", "15: FizzBuzz", "16", "17", "18: Fizz", "19",
                "20: Buzz", "21: Fizz", "22", "23", "24: Fizz", "25: Buzz", "26", "27: Fizz", "28", "29",
                "30: FizzBuzz", "31", "32", "33: Fizz", "34", "35: Buzz", "36: Fizz", "37", "38", "39: Fizz",
                "40: Buzz", "41", "42: Fizz", "43", "44", "45: FizzBuzz", "46", "47", "48: Fizz", "49",
                "50: Buzz", "51: Fizz", "52", "53", "54: Fizz", "55: Buzz", "56", "57: Fizz", "58", "59",
                "60: FizzBuzz", "61", "62", "63: Fizz", "64", "65: Buzz", "66: Fizz", "67", "68", "69: Fizz",
                "70: Buzz", "71", "72: Fizz", "73", "74", "75: FizzBuzz", "76", "77", "78: Fizz", "79",
                "80: Buzz", "81: Fizz", "82", "83", "84: Fizz", "85: Buzz", "86", "87: Fizz", "88", "89",
                "90: FizzBuzz", "91", "92", "93: Fizz", "94", "95: Buzz", "96: Fizz", "97", "98", "99: Fizz"
            };
        private readonly SimpleFizzbuzz _fizzBuzz = new SimpleFizzbuzz();
        #endregion

        #region CheckDivisibility Tests

        [Test]
        [Category("SimpleFizzBuzz Check Divisibility")]
        public void CheckDivisibility_Returns_True_When_Modulus_Is_Zero()
        {
            var a = new int[]
            {
                0, 4, 9, 16, 25, 36
            };
            var b = new int[]
            {
                1, 2, 3, 4, 5, 6
            };

            for (int i = 0; i < a.Length; i++)
            {
                var divisibility = _fizzBuzz.CheckDivisibility(a[i], b[i]);

                Assert.IsTrue(divisibility);
            }
        }

        [Test]
        [Category("SimpleFizzBuzz Check Divisibility")]
        public void CheckcDivisibility_Returns_False_When_Modulus_Is_Not_Zero()
        {
            var a = new int[]
            {
                7, 13, 17, 23, 113, 247
            };
            var b = new int[]
            {
                2, 3, 4, 5, 6, 7
            };

            for (int i = 0; i < a.Length; i++)
            {
                var divisibility = _fizzBuzz.CheckDivisibility(a[i], b[i]);

                Assert.IsFalse(divisibility);
            }
        }

        [Test]
        [Category("SimpleFizzBuzz Check Divisibility")]
        public void CheckcDivisibility_Throws_ArgumentException_When_B_Is_Zero()
        {
            var a = 5;
            var b = 0;

            Assert.That(() => _fizzBuzz.CheckDivisibility(a, b), Throws.ArgumentException);
        }
        #endregion

        #region GetDivisibilityMessage Tests

        [Test]
        [Category("SimpleFizzBuzz GetDivisibilityMessage")]
        public void GetDivisibilityMessage_Returns_FizzBuzz_When_Divisible_By_3_And_5()
        {
            var number = new int[]
            {
                -30, 30, 75, 300, 3000
            };
            var message = new string[]
            {
                "-30: FizzBuzz",
                "30: FizzBuzz",
                "75: FizzBuzz",
                "300: FizzBuzz",
                "3000: FizzBuzz"
            };

            for (int i = 0; i < number.Length; i++)
            {
                var actualMessage = _fizzBuzz.GetDivisibilityMessage(number[i]);

                Assert.AreEqual(message[i], actualMessage);
            }
        }

        [Test]
        [Category("SimpleFizzBuzz GetDivisibilityMessage")]
        public void GetDivisibilityMessage_Returns_Fizz_When_Divisible_By_3()
        {
            var number = new int[]
            {
                -27, 33, 123, 333, 3333
            };
            var message = new string[]
            {
                "-27: Fizz",
                "33: Fizz",
                "123: Fizz",
                "333: Fizz",
                "3333: Fizz"
            };

            for (int i = 0; i < number.Length; i++)
            {
                var actualMessage = _fizzBuzz.GetDivisibilityMessage(number[i]);

                Assert.AreEqual(message[i], actualMessage);
            }
        }

        [Test]
        [Category("SimpleFizzBuzz GetDivisibilityMessage")]
        public void GetDivisibilityMessage_Returns_Buzz_When_Divisible_By_5()
        {
            var number = new int[]
            {
                -35, 35, 55, 560, 5555
            };
            var message = new string[]
            {
                "-35: Buzz",
                "35: Buzz",
                "55: Buzz",
                "560: Buzz",
                "5555: Buzz"
            };

            for (int i = 0; i < number.Length; i++)
            {
                var actualMessage = _fizzBuzz.GetDivisibilityMessage(number[i]);

                Assert.AreEqual(message[i], actualMessage);
            }
        }

        [Test]
        [Category("SimpleFizzBuzz GetDivisibilityMessage")]
        public void GetDivisibilityMessage_Returns_Number_When_Not_Divisible_By_Cases()
        {
            var number = new int[]
            {
                -23, 23, 74, 776, 7777
            };
            var message = new string[]
            {
                "-23",
                "23",
                "74",
                "776",
                "7777"
            };

            for (int i = 0; i < number.Length; i++)
            {
                var actualMessage = _fizzBuzz.GetDivisibilityMessage(number[i]);

                Assert.AreEqual(message[i], actualMessage);
            }
        }
        #endregion

        #region GetDivisibilityMessagesAcrossRange

        [Test]
        [Category("SimpleFizzBuzz MessagesAcrossRange")]
        public void GetDivisibilityMessages_Returns_Correct_Messages_With_Given_Any_Range()
        {
            int start = -100;
            int end = -95;
            int interval = end - start;

            for (int i = 0; i < _fizzBuzzExpected.Length - interval; i++)
            {
                var messages = _fizzBuzz.GetDivisibilityMessagesAcrossRange(start, end);
                var expectedMessages = _fizzBuzzExpected.Skip(i)
                                                        .Take(interval)
                                                        .ToArray();

                Assert.AreEqual(expectedMessages, messages);
                start++;
                end++;
            }
        }

        [Test]
        [Category("SimpleFizzBuzz MessagesAcrossRange")]
        public void GetDivisibilityMessages_Throws_ArgumentException_When_End_Is_Less_Than_Start()
        {
            const int end = 0;
            const int start = 5;

            Assert.That(() => _fizzBuzz.GetDivisibilityMessagesAcrossRange(start, end), Throws.ArgumentException);
        }
        #endregion
    }
}
