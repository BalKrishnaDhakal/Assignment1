using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational rat1 = new Rational(0, 1);
            Rational rat2 = new Rational(1, 1);
            Rational rat3 = new Rational(2, 3);
            Rational rat4 = new Rational(3, 2);
            Console.WriteLine("\t|-------------------------------------------- |");
            Console.WriteLine("\t|The four original rational numbers are:      |");
            Console.WriteLine("\t|-------------------------------------------- |");
            Console.WriteLine("\t| {0} , {1} , {2},  {3}                           |", rat1,rat2,rat3,rat4);
            rat2.IncreasedBy(rat3);
            Console.WriteLine("\t|-------------------------------------------- |");
            Console.WriteLine("\t|The sum of 1 and 2/3 is {0}                  |",rat2);
            rat4.DecreasedBy(rat3);
            Console.WriteLine("\t|-------------------------------------------- |");
            Console.WriteLine("\t|The Diff of 3/2 and 2/3 is {0}               |", rat4);
            Console.WriteLine("\t|-------------------------------------------- |");          
            Console. ReadKey();
        }
    }
}
