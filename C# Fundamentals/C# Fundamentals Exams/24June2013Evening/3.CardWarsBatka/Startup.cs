using System;

namespace _3.CardWarsBatka
{
    class Startup
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            long firstPlayerPoints = 0;
            long secondPlayerPoints = 0;
            int firstPlayerGameWon = 0;
            int secondPlayerGameWon = 0;

            bool xWasDrown = false;

            for (int i = 0; i < n; i++)
            {
                
                bool xCardDrawnByBoughtPlayer = false;

                long firstPlayerCurrentHand = 0;
                long secondPlayerCurrentHand = 0;

                int firstPlayerX = 0;
                int firstPlayerZ = 0;
                int firstPlayerY = 0;

                int secondPlayerX = 0;
                int secondPlayerZ = 0;
                int secondPlayerY = 0;

                for (int j = 0; j < 3; j++)
                {
                    var cuurentCard = Console.ReadLine();

                    try
                    {
                        int card = int.Parse(cuurentCard);
                        firstPlayerCurrentHand += 12 - card;
                    }
                    catch (Exception ex)
                    {
                        switch (cuurentCard)
                        {
                            case "X":
                                firstPlayerX++;
                                break;
                            case "Y":
                                firstPlayerY++;
                                break;
                            case "Z":
                                firstPlayerZ++;
                                break;
                            case "A":
                                firstPlayerCurrentHand += 1;
                                break;
                            case "J":
                                firstPlayerCurrentHand += 11;
                                break;
                            case "Q":
                                firstPlayerCurrentHand += 12;
                                break;
                            case "K":
                                firstPlayerCurrentHand += 13;
                                break;

                        }
                    }

                }




                for (int j = 0; j < 3; j++)
                {
                    var cuurentCard = Console.ReadLine();

                    try
                    {
                        int card = int.Parse(cuurentCard);
                        secondPlayerCurrentHand += 12 - card;
                    }
                    catch (Exception ex)
                    {
                        switch (cuurentCard)
                        {
                            case "X":
                                secondPlayerX++;
                                break;
                            case "Y":
                                secondPlayerY++;
                                break;
                            case "Z":
                                secondPlayerZ++;
                                break;
                            case "A":
                                secondPlayerCurrentHand += 1;
                                break;
                            case "J":
                                secondPlayerCurrentHand += 11;
                                break;
                            case "Q":
                                secondPlayerCurrentHand += 12;
                                break;
                            case "K":
                                secondPlayerCurrentHand += 13;
                                break;

                        }
                    }
                }


                if (firstPlayerX > 0 && secondPlayerX == 0)
                {
                    //X card drawn!Player two wins the match!

                    Console.WriteLine("X card drawn! Player one wins the match!");
                    xWasDrown = true;
                    break;
                }
                else if (firstPlayerX == 0 && secondPlayerX > 0)
                {
                    Console.WriteLine("X card drawn! Player two wins the match!");
                    xWasDrown = true;
                    break;
                }
                else if (firstPlayerX > 0 && secondPlayerX > 0)
                {
                    xCardDrawnByBoughtPlayer = true;
                    firstPlayerPoints += 50;
                    secondPlayerPoints += 50;
                   
                }

                firstPlayerPoints *= (int)Math.Pow(2, firstPlayerZ);
                secondPlayerPoints *= (int)Math.Pow(2, secondPlayerZ);

                firstPlayerPoints -= firstPlayerY * 200;
                secondPlayerPoints -= secondPlayerY * 200;

                if (firstPlayerCurrentHand > secondPlayerCurrentHand)
                {
                    firstPlayerGameWon++;
                    firstPlayerPoints += firstPlayerCurrentHand;
                }
                else if (secondPlayerCurrentHand > firstPlayerCurrentHand)
                {
                    secondPlayerGameWon++;
                    secondPlayerPoints += secondPlayerCurrentHand;
                }

            }

            if (!xWasDrown)
            {
                if (firstPlayerPoints > secondPlayerPoints)
                {
                    //First player wins!
                    //Score: S
                    //Games won: G

                    Console.WriteLine("First player wins!");
                    Console.WriteLine("Score: {0}", firstPlayerPoints);
                    Console.WriteLine("Games won: {0}", firstPlayerGameWon);
                }
                else if (secondPlayerPoints > firstPlayerPoints)
                {
                    //Second player wins!
                    //Score: S
                    //Games won: G

                    Console.WriteLine("Second player wins!");
                    Console.WriteLine("Score: {0}", secondPlayerPoints);
                    Console.WriteLine("Games won: {0}", secondPlayerGameWon);
                }
                else
                {
                    //                    It"s a tie!
                    //Score: S
                    Console.WriteLine("It\'s a tie!");
                    Console.WriteLine("Score: {0}", secondPlayerPoints);
                }
            }
        }
    }
}
