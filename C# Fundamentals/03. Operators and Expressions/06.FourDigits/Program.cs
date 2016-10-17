using System;

namespace _06.FourDigits
{
    class Program
    {
        static void Main()
        {
            string numberAsString = Console.ReadLine();

            char firstDigit = numberAsString[0];
            char secondDigit = numberAsString[1];
            char thirdDigit = numberAsString[2];
            char fourthDigit = numberAsString[3];

            //because char are representet as digits in UTF- 8 format so we subtract 48 witch is 0 to find the sum of all digits
            int sum = firstDigit + secondDigit + thirdDigit + fourthDigit - 4 * 48;

            //original is abcd
            string reverse = "" + fourthDigit + thirdDigit + secondDigit + firstDigit;
            string dabc = "" + fourthDigit + firstDigit + secondDigit + thirdDigit;
            string acbd = "" + firstDigit + thirdDigit + secondDigit + fourthDigit;

            Console.WriteLine(sum);
            Console.WriteLine(reverse.ToString());
            Console.WriteLine(dabc);
            Console.WriteLine(acbd);

        }
    }
}
