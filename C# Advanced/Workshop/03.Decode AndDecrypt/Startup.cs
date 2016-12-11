using System;
using System.Text;

namespace _03.DecodeAndDecrypt
{
    class Startup
    {
        static void Main()
        {
            var input = Console.ReadLine();


            var index = input.Length - 1;
            var lengthAsString = "";

            while (true)
            {
                if (char.IsLetter(input[index]))
                {
                    break;
                }

                lengthAsString = input[index] + lengthAsString;

                index--;
            }

            var cypherLength = int.Parse(lengthAsString);

            var decompresedMessage = new StringBuilder();
            for (int i = 0; i < input.Length - lengthAsString.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    var times = 0;
                    while (char.IsDigit(input[i]))
                    {
                        times = times * 10 + (input[i] - 48);
                        i++;
                    }
                    decompresedMessage.Append(new string(input[i], times));
                    
                }
                else
                {
                    decompresedMessage.Append(input[i]);
                }

            }

            var message = decompresedMessage.ToString().Substring(0, decompresedMessage.Length - cypherLength).ToCharArray();
            var cypher = decompresedMessage.ToString().Substring(decompresedMessage.Length - cypherLength).ToCharArray();

            var result = new StringBuilder();

            var maxLength = Math.Max(message.Length, cypher.Length);
            var minLength = Math.Min(message.Length, cypher.Length);


            //for (int i = 0; i < maxLength; i++)
            //{
            //    var currentChar = ((message[i % message.Length] - 65) ^ (cypher[i % cypher.Length] - 65));

            //    for (int j = 1; j <= maxLength % minLength; j++)
            //    {
            //        currentChar = ((currentChar ^ (cypher[message.Length + i] - 65)) + 65);
            //    }

            //    result.Append((char)currentChar);
            //}


            for (int i = 0; i < maxLength; i++)
            {

            }

            if (cypher.Length > message.Length)
            {
                for (int i = 0; i < minLength; i++)
                {
                    var currentChar = ((message[i % message.Length] - 65) ^ (cypher[i % cypher.Length] - 65));

                    for (int j = i; j < maxLength / minLength; j++)
                    {
                        currentChar = ((currentChar ^ (cypher[minLength * j] - 65)));
                    }

                    result.Append((char)(currentChar + 65));

                }
            }
            else
            {
                for (int i = 0; i < message.Length; i++)
                {
                    var currentChar = (char)(((message[i] - 65) ^ (cypher[i % cypher.Length] - 65)) + 65);
                    result.Append(currentChar);
                }
            }

            Console.WriteLine(result);

        }
    }
}
