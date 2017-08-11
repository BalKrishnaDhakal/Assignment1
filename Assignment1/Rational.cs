using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Bal Krishna Dhakal
 * StudentID: 300916314
 * Description: Assignment1
 */ 
/// <summary>
/// This is my Assignment1
/// </summary>
namespace Assignment1
{
    class Rational
    {
        public int Denominator {get; private set;}
        public int Numerator {get; private set;}
        public Rational(int numerator=0, int denominator = 1)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public override string ToString()
        {
            if (Denominator != 1)
            {
                return string.Format("{0}/{1}", Numerator, Denominator);
            }
            else
            {
                return string.Format("{0}", Numerator);
            }
        }
        public void IncreasedBy(Rational other)
        {
            Numerator = this.Numerator * other.Denominator + this.Denominator * other.Numerator;
            Denominator = this.Denominator * other.Denominator;
        }
        public void DecreasedBy(Rational other)
        {
            Numerator = this.Numerator * other.Denominator - this.Denominator * other.Numerator;
            Denominator = this.Denominator * other.Denominator;
        }
    }
}

