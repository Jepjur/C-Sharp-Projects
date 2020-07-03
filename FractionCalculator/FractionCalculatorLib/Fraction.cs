using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculatorLib
{
    public class Fraction
    {
        #region fields
        private int _numerator;
        private int _denominator;
        #endregion

        public int Numerator
        {
            get { return _numerator; }
        }

        public int Denominator
        {
            get { return _denominator; }
        }

        #region constructors
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("You cannot divide by zero");
            // If the denominator is negative, make the numerator negative instead
            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }
            _numerator = numerator;
            _denominator = denominator;

        }

        public Fraction(int numerator):this(numerator, 1) { }

        public Fraction() : this(0, 1) { }

        #endregion

        public int GetNumerator()
        {
            return _numerator;
        }

        public int GetDenominator()
        {
            return Denominator;
        }

        // Returns the fraction as a string
        public override string ToString()
        {
            return Denominator == 1 ? Numerator.ToString() : $"{Numerator}/{Denominator}";
        }

        public double ToDouble()
        {
            return (Numerator / Denominator);
        }

        // Add, subtract, multiply and divide methods for the calculator
        public Fraction Add(Fraction fraction)
        {
            int num = fraction.Numerator + Numerator;
            int den = fraction.Denominator + Denominator;
            return new Fraction(num, den);
        }

        public Fraction Subtract(Fraction fraction)
        {
            int num = fraction.Numerator - Numerator;
            int den = fraction.Denominator - Denominator;
            return new Fraction(num, den);
        }

        public Fraction Multiply(Fraction fraction)
        {
            int num = fraction.Numerator * Numerator;
            int den = fraction.Denominator * Denominator;
            return new Fraction(num, den);
        }

        public Fraction Divide(Fraction fraction)
        {
            int num = fraction.Numerator / Numerator;
            int den = fraction.Denominator / Denominator;
            return new Fraction(num, den);
        }

        // Check if two fractions are equal
        public bool Equals(Fraction fraction)
        {
            bool isEqual = fraction.ToDouble() == ToDouble();
            return isEqual;
        }

        // Convert a fraction to the lowest possible terms
        public void ToLowestTerms()
        {
            int gcd = Gcd(Numerator, Denominator);
            _numerator = Numerator / gcd;
            _denominator = Denominator / gcd;
        }

        // Find the greatest common denominator
        public static int Gcd(int numerator, int denominator)
        {
            // If numerator is negative turn it positive
            if (Math.Sign(numerator) == -1)
            {
                numerator *= -1;
            }

            if (Math.Sign(denominator) == -1)
            {
                denominator *= -1;
            }

            while (numerator != 0 || denominator != 0)
            {
                int remainder = numerator % denominator;
                numerator = denominator;
                denominator = remainder;
            }
            return numerator;
        }



    }
}
