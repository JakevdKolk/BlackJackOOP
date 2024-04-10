using System.Collections.Generic;
using System.Numerics;

namespace BlackJackOOP
{
    internal class Program
    {

 
        static void Main()
        {

            BlackjackSetup setup = new BlackjackSetup();
            List<PlayerBasic> players = setup.blackjackUserOptions();
            Card card = new Card();
            blackjackAI ai = new blackjackAI();
            
            
           
            PlayerBasic player = new PlayerBasic(); 
            player.Name = "Test";
           
            foreach (PlayerBasic p in players)
            {
                int actionCount = 2;
               
                if(p.pointCount !> 21)
                {
                    if (p.checkIfDouble(p))
                    {
                        actionCount++;
                        //p.Double(p);
                    }
                    if (p.checkIfSplit(p))
                    {

                    }
                    
                }
                else
                {
                    Console.WriteLine("Player lost");
                }

            }
            
            CardDeck cardDeck = new CardDeck();

            //Initialze dealer
            Dealer dealer = new Dealer();
            cardDeck.initializeDeck();

            Chips chips = new Chips();

            chips.initializeChipCount(player);


            cardDeck.cardDeck = dealer.shuffleCards(cardDeck.cardDeck);



                foreach (KeyValuePair<string, int> cardType in cardDeck.cardDeck)
            {
                Console.Write(cardType.Key);
                Console.WriteLine(cardType.Value);

            }

            //give out two cards
          
          
            player.Hit(dealer, cardDeck.cardDeck, player);
            Console.WriteLine("Hit");
            //player.Hit(dealer, cardDeck.cardDeck, player);
            player.stand(player);
            player.Split(player);


            Console.Write("Pointcount: ");
            Console.WriteLine(player.pointCount);
            Console.WriteLine("Chips: ");
            Console.Write(player.chips);

            Console.WriteLine("second loop");
            foreach (KeyValuePair<string, int> cardType in player.Cards)
            {
                Console.Write(cardType.Key);
                Console.WriteLine(cardType.Value);

            }









            //            foreach (string deck in deckOfCards)
            //            {
            //              Console.WriteLine(deck);
            //        }


        }
    }
}
