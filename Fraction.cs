using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorrectFinal;


namespace CorrectFinal
{
    public class Fraction: IComparable
    {
        public int num = 0;
        public int den = 1;

        public Fraction()
        {
        }
        // Get the two fractions that the user wants to calculate, also check if den is 0
        public static Fraction Parse(string str)
        {
            Fraction newFrac = new Fraction();

            if (str == null)
            {
                throw new ArgumentException("Input string is null.");
            }

            int indexSlash = str.IndexOf("/");

            if (indexSlash == -1)
            {
                throw new ArgumentException("No '/' to create fraction.");
            }

            if (!int.TryParse(str.Substring(0, indexSlash), out newFrac.num) ||
                !int.TryParse(str.Substring(indexSlash + 1), out newFrac.den))
            {
                throw new ArgumentException("Invalid input format");
            }

            if (newFrac.den == 0)
            {
                throw new ArgumentException("Denominator cannot be 0.");
            }

            return newFrac;
        }


        public static Fraction operator +(Fraction firstFrac, Fraction secondFrac)
        {
            Fraction sumFracs = new Fraction();
            sumFracs.num = (firstFrac.num * secondFrac.den + secondFrac.num * firstFrac.den);
            sumFracs.den = (firstFrac.den * secondFrac.den);
            return sumFracs;
        }

        // Subtracts two fractions from user input
        public static Fraction operator -(Fraction firstFrac, Fraction secondFrac)
        {
            Fraction diffFracs = new Fraction();
            diffFracs.num = (firstFrac.num * secondFrac.den) - (firstFrac.den * secondFrac.num);
            diffFracs.den = (firstFrac.den * secondFrac.den);
            return diffFracs;
        }

        // Multiplies two fractions from user input
        public static Fraction operator *(Fraction firstFrac, Fraction secondFrac)
        {
            Fraction prodFracs = new Fraction();
            prodFracs.num = firstFrac.num * secondFrac.num;
            prodFracs.den = firstFrac.den * secondFrac.den;
            return prodFracs;
        }

        // Divides two fractions from user input
        public static Fraction operator /(Fraction dividend, Fraction divisor)
        {
            Fraction quoFracs = new Fraction();
            quoFracs.num = dividend.num * divisor.den;
            quoFracs.den = dividend.den * divisor.num;
            return quoFracs;
        }

        public static bool operator ==(Fraction a, Fraction b) 
        {
            return (a.num == b.num) && (a.den == b.den);
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return (a.num == b.num) && (a.den == b.den);
        }

        // Display the result back to user.
        public override string ToString()
        {
            return num.ToString() + "/" + den.ToString();
        }

        // Create a CompareTo method in order to user Array.sort (used method from lesson 8)
        public int CompareTo(object rightObject)
        {
            // typecast the object parameter to a Fraction
            Fraction rightFrac = (Fraction)rightObject;

            double f1 = (double)(this.num) / (double)(this.den);
            double f2 = (double)(rightFrac.num) / (double)(rightFrac.den);

            int retVal = 0;
            if (f1 < f2)
                retVal = -1;
            else if (f1 == f2)
                retVal = 0;
            else
                retVal = 1;

            return retVal;
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj is Fraction)
                equals = (this == (Fraction)obj); 
            return equals;
        }

    }

}
