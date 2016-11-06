using System;
using System.Text;

namespace _8.BunnyFactory
{
    class Startup
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int i = 1;

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                sb.Append(input);

            }

            while (true)
            {
                int cages = 0;
                for (int j = 0; j < i; j++)
                {
                    if (j < sb.Length)
                    {
                        cages += sb[j] - '0';
                    }

                }

                if (cages > sb.Length - i || cages == 0)
                {
                    break;
                }
                else
                {

                }
            }

            Console.WriteLine(string.Join(" ", sb.ToString().ToCharArray()));
        }
    }
}
