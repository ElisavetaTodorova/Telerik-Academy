using System;

namespace _5.SearchInBits
{
    class Startup
    {
        static void Main()
        {
            var s = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            var sInBinary = Convert.ToString(s, 2).PadLeft(4, '0');

            var searchedBits = sInBinary.Substring(sInBinary.Length - 4);

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                var number = long.Parse(Console.ReadLine());

                var numberInBinary = Convert.ToString(number, 2).PadLeft(30, '0');

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
