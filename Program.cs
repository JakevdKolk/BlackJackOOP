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

            /*
            foreach(PlayerBasic player in players) {
                Console.WriteLine(player.Name);
            }*/
            PlayerBasic player = new PlayerBasic();            
            
            
            CardDeck cardDeck = new CardDeck();

            //Initialze dealer
            Dealer dealer = new Dealer();


           

            

             string[] deckOfCards = cardDeck.initializeDeck();

          
            dealer.shuffleCards(deckOfCards);
            for (int i = 0; i < 2; i++) {
                (string firstCard, string[] sortedDeckOfCards) = dealer.giveOutCards(deckOfCards, player);

                deckOfCards = sortedDeckOfCards;

            }



            foreach (string playertest in player.cards)
            {
                Console.WriteLine("with this i summon");
                Console.WriteLine(playertest);
            }




            foreach (string deck in deckOfCards)
              {
                  Console.WriteLine(deck);
              }


        }
    }
}
