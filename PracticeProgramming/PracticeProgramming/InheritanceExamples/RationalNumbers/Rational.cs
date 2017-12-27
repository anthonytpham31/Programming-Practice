using System;

namespace PracticeProgramming.InheritanceExamples.RationalNumbers
{
    public abstract class Rational
    {
        public virtual int Numerator { get; set; }
        public virtual int Denominator { get; set; }

        public Rational(int numerator, int denominator)
        {
            if (denominator == 0) throw new ArgumentException();
            Numerator = numerator;
            Denominator = denominator;
        }

        public override string ToString()
        {
            if (Numerator > 0 && Denominator > 0) return $"{Numerator * (-1)}/{Denominator * (-1)}";
            if (Numerator < 0 && Denominator > 0) return $"-{Numerator * (-1)}/{Denominator}";
            if (Numerator > 0 && Denominator < 0) return $"-{Numerator}/{Denominator * (-1)}";
            return $"{Numerator}/{Denominator}";
        }
    }
}