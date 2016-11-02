using System;

namespace _5.FindBits
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            var sInBinary = Convert.ToString(s, 2).PadLeft(5, '0');

            var searchedBits = sInBinary.Substring(sInBinary.Length - 5);

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                var number = long.Parse(Console.ReadLine());

                var numberInBinary = Convert.ToString(number, 2).PadLeft(29, '0');

                int startIndex = 0;
                int index = numberInBinary.IndexOf(searchedBits, startIndex);

                while (index != -1 && startIndex < numberInBinary.Length)
                {
                    count++;
                    startIndex = index + 1;
                    index = numberInBinary.IndexOf(searchedBits, startIndex);
                }
            }

            Console.WriteLine(count);

        }
    }
}
