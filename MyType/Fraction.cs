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

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            int newNumerator;
            int newDenominator;

            if (fraction1.Denominator == fraction2.Denominator)
            {
                newNumerator = fraction1.Numerator + fraction2.Numerator;
                newDenominator = fraction1.Denominator;
            }
            else
            {
                newNumerator = fraction1.Numerator * fraction2.Denominator + fraction2.Numerator * fraction1.Denominator;
                newDenominator = fraction1.Denominator * fraction2.Denominator;
            }

            return new Fraction(newNumerator, newDenominator);
        }



        // Вычитание
        //public Fraction Subtract(Fraction other)
        //{
        //    int newNumerator;
        //    int newDenominator;

        //    if (Denominator == other.Denominator)
        //    {
        //        newNumerator = Numerator - other.Numerator;
        //        newDenominator = Denominator;
        //    }
        //    else
        //    {
        //        newNumerator = Numerator * other.Denominator - other.Numerator * Denominator;
        //        newDenominator = Denominator * other.Denominator;
        //    }

        //    return new Fraction(newNumerator, newDenominator);
        //}

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            int newNumerator;
            int newDenominator;

            if (fraction1.Denominator == fraction2.Denominator)
            {
                newNumerator = fraction1.Numerator - fraction2.Numerator;
                newDenominator = fraction1.Denominator;
            }
            else
            {
                newNumerator = fraction1.Numerator * fraction2.Denominator - fraction2.Numerator * fraction1.Denominator;
                newDenominator = fraction1.Denominator * fraction2.Denominator;
            }

            return new Fraction(newNumerator, newDenominator);
        }

        // Умножение
        public static Fraction operator *(Fraction fraction1, Fraction fraction2)
        {
            int newNumerator = fraction1.Numerator * fraction2.Numerator;
            int newDenominator = fraction1.Denominator * fraction2.Denominator;

            return new Fraction(newNumerator, newDenominator);
        }


        // Деление
        public static Fraction operator /(Fraction fraction1, Fraction fraction2)
        {
            // Проверка на деление на ноль
            if (fraction2.Numerator == 0)
            {
                throw new ArgumentException("Деление на ноль невозможно");
            }

            int newNumerator = fraction1.Numerator * fraction2.Denominator;
            int newDenominator = fraction1.Denominator * fraction2.Numerator;

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
