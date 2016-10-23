using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaximumSeaqunce
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int maxLength = 0;
            int currentLenth = 1;
            for (int i = 0; i < n - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentLenth++;
                }
                else
                {
                    maxLength = Math.Max(currentLenth, maxLength);
                    currentLenth = 1;
                }
            }
            Console.WriteLine(maxLength);
        }
    }
}
