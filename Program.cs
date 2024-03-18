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

            
           
            PlayerBasic player = new PlayerBasic(); 
            player.Name = "Test";
            
            
            CardDeck cardDeck = new CardDeck();

            //Initialze dealer
            Dealer dealer = new Dealer();


           

            

             string[] deckOfCards = cardDeck.initializeDeck();

          
            dealer.shuffleCards(deckOfCards);
            //give out two cards
            for (int i = 0; i < 2; i++) {
                string[] sortedDeckOfCards = dealer.giveOutCards(deckOfCards, player);

                deckOfCards = sortedDeckOfCards;

            }

            foreach (string deck in player.Cards)
            {
                Console.WriteLine(deck);
            }








            //            foreach (string deck in deckOfCards)
            //            {
            //              Console.WriteLine(deck);
            //        }


        }
    }
}
