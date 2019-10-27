using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_tema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. C# Program to Check Whether the Entered Year is a Leap Year or Not
            //Console.WriteLine(LeapYear(560));

            //2. You have data in a file in two rows. On the third row save the sum of the numbers above.
            SumUpLines();

            Console.ReadKey();
        }

        private static void SumUpLines()
        {
            string path = @"C:\Users\Vera\source\.NET course\Week3_tema2\Week3_tema 2\Test file.txt";

            var lines = File.ReadLines(path);

            int sum = 0;

            foreach (var item in lines)
            {
                sum += int.Parse(item);
            }

            string s = "\n" + sum.ToString();

            File.AppendAllText(path, s);
        }

        private static bool LeapYear(int x)
        {
            if (x % 4 ==0 && x > 400)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
