using System;


namespace DeckOfCards
{
    class DeckOfCards
    {
        static void Main()
        {
            // Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). The cards should be printed with their English names. 

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    switch (i)
                    {
                        case 0:
                            Console.Write("Two of ");
                            break;
                        case 1:
                            Console.Write("Three of ");
                            break;
                        case 2:
                            Console.Write("Four of ");
                            break;
                        case 3:
                            Console.Write("Five of ");
                            break;
                        case 4:
                            Console.Write("Six of ");
                            break;
                        case 5:
                            Console.Write("Seven of ");
                            break;
                        case 6:
                            Console.Write("Eight of ");
                            break;
                        case 7:
                            Console.Write("Nine of ");
                            break;
                        case 8:
                            Console.Write("Ten of ");
                            break;
                        case 9:
                            Console.Write("Jack of ");
                            break;
                        case 10:
                            Console.Write("Queen of ");
                            break;
                        case 11:
                            Console.Write("King of ");
                            break;
                        case 12:
                            Console.Write("Ace of ");
                            break;
                        default:
                            Console.WriteLine("There is some mistake");
                            break;
                    }
                    switch (j)
                    {
                        case 0:
                            Console.WriteLine("Spades");
                            break;
                        case 1:
                            Console.WriteLine("Hearts");
                            break;
                        case 2:
                            Console.WriteLine("Diamonds");
                            break;
                        case 3:
                            Console.WriteLine("Clubs");
                            break;
                        default:
                            Console.WriteLine("There si some mistake!");
                            break;
                    }
                }
            }
        }
    }
}

                                    
                                    

                            
                                
                            
                            

