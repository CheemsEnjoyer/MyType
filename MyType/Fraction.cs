using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyType
{
    public class Fraction
    {
        private int value;
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public string Verbose()
        {
            return String.Format("{0}", this.value);
        }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен 0");

            Numerator = numerator;
            Denominator = denominator;
        }

        // Сложение
        //public Fraction Add(Fraction other)
        //{
        //    int newNumerator;
        //    int newDenominator;

        //    if (Denominator == other.Denominator)
        //    {
        //        newNumerator = Numerator + other.Numerator;
        //        newDenominator = Denominator;
        //    }
        //    else
        //    {
        //        newNumerator = Numerator * other.Denominator + other.Numerator * Denominator;
        //        newDenominator = Denominator * other.Denominator;
        //    }

        //    return new Fraction(newNumerator, newDenominator);
        //}

        public static Fraction operator +(Fraction other, Fraction other1)
        {
            int newNumerator;
            int newDenominator;

            int denominator = other.Denominator;
            if (other.Denominator == denominator)
            {
                newNumerator = other.Numerator + other1.Numerator;
                newDenominator = other.Denominator;
            }
            else
            {
                newNumerator = other.Numerator * denominator + other1.Numerator * other1.Denominator;
                newDenominator = other1.Denominator * denominator;
            }

            return new Fraction(newNumerator, newDenominator);
        }


        // Вычитание
        public Fraction Subtract(Fraction other)
        {
            int newNumerator;
            int newDenominator;

            if (Denominator == other.Denominator)
            {
                newNumerator = Numerator - other.Numerator;
                newDenominator = Denominator;
            }
            else
            {
                newNumerator = Numerator * other.Denominator - other.Numerator * Denominator;
                newDenominator = Denominator * other.Denominator;
            }

            return new Fraction(newNumerator, newDenominator);
        }

        public static Fraction operator -(Fraction other, Fraction other1)
        {
            int newNumerator;
            int newDenominator;

            if (other1.Denominator == other.Denominator)
            {
                newNumerator = other1.Numerator - other.Numerator;
                newDenominator = other.Denominator;
            }
            else
            {
                newNumerator = Numerator * other.Denominator - other.Numerator * Denominator;
                newDenominator = Denominator * other.Denominator;
            }

            return new Fraction(newNumerator, newDenominator);
        }
        // Умножение
        public Fraction Multiply(Fraction other)
        {
            int newNumerator = Numerator * other.Numerator;
            int newDenominator = Denominator * other.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        // Деление
        public Fraction Divide(Fraction other)
        {
            if (other.Numerator == 0)
                throw new ArgumentException("Нельзя разделить на 0");

            int newNumerator = Numerator * other.Denominator;
            int newDenominator = Denominator * other.Numerator;
            return new Fraction(newNumerator, newDenominator);
        }

        // Сокращение дроби
        public void Simplify()
        {
            int gcd = NOD(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;
        }

        // НОД
        private int NOD(int a, int b)
        {
            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }

            return a;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        // Сравнение
        public int CompareTo(Fraction other)
        {
            int thisValue = Numerator * other.Denominator;
            int otherValue = other.Numerator * Denominator;
            return thisValue.CompareTo(otherValue);
        }
    }
}
