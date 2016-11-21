using System;
using System.Linq;

namespace _11.AddingPolynomials
{
    class Startup
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var firstPolynom = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondPolynom = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var result = AddPolynomials(firstPolynom, secondPolynom, n);

            Console.WriteLine(string.Join(" ", result));

        }

        private static int[] AddPolynomials(int[] firsPolinomial, int[] secondPolynomial, int n)
        {
            var result = new int[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = firsPolinomial[i] + secondPolynomial[i];
            }
            return result;
        }
    }
}
