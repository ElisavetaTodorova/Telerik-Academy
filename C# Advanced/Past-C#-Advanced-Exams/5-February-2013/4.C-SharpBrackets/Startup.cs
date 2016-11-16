using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.C_SharpBrackets
{
    class Startup
    {
        static void Main()
        {

            var numberOfLine = int.Parse(Console.ReadLine());
            var symbols = Console.ReadLine();

            var symbeolLength = symbols.Length;
            var symbol = symbols[0];


            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);

            var result = new List<string>();

            var brackets = 0;

            for (int i = 0; i < numberOfLine; i++)
            {
                var line = Console.ReadLine();

                line = regex.Replace(line, " ");

                int indexOfOppeningBracket = line.IndexOf('{');
                int indexOfClosingBracket = line.IndexOf('}');

                if (indexOfOppeningBracket != -1 || indexOfClosingBracket != -1)
                {
                    bool wasIncreased = false;
                    while (indexOfOppeningBracket != -1 || indexOfClosingBracket != -1)
                    {
                       
                        if (indexOfOppeningBracket != -1)
                        {

                            string temp = "";

                            if (indexOfOppeningBracket > 0)
                            {
                                temp = new string(symbol, brackets * symbeolLength) + line.Substring(0, indexOfOppeningBracket).Trim();
                            }

                            if (temp != "")
                            {
                                result.Add(temp);
                            }

                            temp = new string(symbol, brackets * symbeolLength) + "{";
                            if (temp != "")
                            {
                                result.Add(temp);
                            }
                            brackets++;
                            if (indexOfOppeningBracket < line.Length - 1)
                            {
                                line = line.Substring(indexOfOppeningBracket + 1);

                            }
                            else
                            {
                                line = "";
                            }

                            indexOfClosingBracket = line.IndexOf('}');


                        }

                        if (indexOfClosingBracket != -1)
                        {
                            brackets--;

                           

                            string temp = "";
                            if (indexOfClosingBracket > 0)
                            {
                                temp = new string(symbol, brackets * symbeolLength) + line.Substring(0, indexOfClosingBracket).Trim();
                            }

                            if (temp != "")
                            {
                                result.Add(temp);
                            }

                           
                            temp = new string(symbol, brackets * symbeolLength) + "}";
                            if (temp != "")
                            {
                                result.Add(temp);
                            }

                            if (indexOfClosingBracket < line.Length - 1)
                            {
                                line = line.Substring(indexOfClosingBracket + 1);

                            }
                            else
                            {
                                line = "";
                            }

                            indexOfOppeningBracket = line.IndexOf('{');


                        }

                        indexOfClosingBracket = line.IndexOf('}');
                        indexOfOppeningBracket = line.IndexOf('{');

                    }
                }
                else
                {
                    result.Add(new string(symbol, brackets * symbeolLength) + line.Trim());
                }

            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
