using System.Collections.Generic;
using System.Numerics;

namespace BlackJackOOP
{
    internal class Program
    {

 
        static void Main()
        {

            BlackjackSetup setup = new BlackjackSetup();
            setup.blackjackUserOptions();

            

            
            CardDeck cardDeck = new CardDeck();

            //Initialze dealer
            Dealer dealer = new Dealer();


            

             string[] deckOfCards = cardDeck.initializeDeck();

          
            dealer.shuffleCards(deckOfCards);
            (string firstCard, string[] sortedDeckOfCards) = dealer.giveOutCards(deckOfCards);
            deckOfCards = sortedDeckOfCards;





              foreach (string deck in deckOfCards)
              {
                  Console.WriteLine(deck);
              }


        }
    }
}
