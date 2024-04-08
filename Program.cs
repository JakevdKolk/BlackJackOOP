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
            
           
            PlayerBasic player = new PlayerBasic(); 
            player.Name = "Test";
            
            
            CardDeck cardDeck = new CardDeck();

            //Initialze dealer
            Dealer dealer = new Dealer();
            cardDeck.initializeDeck();

     




            cardDeck.cardDeck = dealer.shuffleCards(cardDeck.cardDeck);



            foreach (KeyValuePair<string, int> cardType in cardDeck.cardDeck)
            {
                Console.Write(cardType.Key);
                Console.WriteLine(cardType.Value);

            }

            //give out two cards
          
          
            player.Hit(dealer, cardDeck.cardDeck, player);
            Console.WriteLine("Hit");
            player.Hit(dealer, cardDeck.cardDeck, player);

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
