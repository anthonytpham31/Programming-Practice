using System;

namespace PracticeProgramming.InheritanceExamples.RationalNumbers
{
    public abstract class Rational
    {
        public virtual int Numerator { get; set; }
        public virtual int Denominator { get; set; }

        protected Rational(int numerator, int denominator)
        {
            throw new NotImplementedException();
        }

    }
}