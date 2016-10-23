using System;

namespace _08.MaximumSum
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

            Console.WriteLine(MaxSubArray(numbers));
        }

        private static int MaxSubArray(int[] A)
        {
            int max = A[0];
            int[] sum = new int[A.Length];
            sum[0] = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                sum[i] = Math.Max(A[i], sum[i - 1] + A[i]);
                max = Math.Max(max, sum[i]);
            }

            return max;
        }
    }
}
