using System;

namespace _13.ComparingFloats
{
    class StartUp
    {
        static void Main()
        {
            var fistNumber = double.Parse(Console.ReadLine());
            var secondNumber = double.Parse(Console.ReadLine());
            var eps = 0.000001;
            var subtraction = Math.Abs(fistNumber - secondNumber);

            if (subtraction < eps)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
