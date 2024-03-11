using Microsoft.VisualBasic;
using System.Reflection.Metadata.Ecma335;

namespace BlackJackOOP
{
    internal class CardDeck
    {

        // Initialze card deck
        public string[] initializeDeck()
        {
            // Get suits
            string[] suits = Suit();

            // Loop trough all suits
            List<String> cardDeck = new List<String>();

            foreach (String suit in suits) {
                //Get cards
                string[] cardTypes = deckOfCards(suit);
                // Loop trough all the cards and add them to the list
                foreach (String cardType in cardTypes) {
                    cardDeck.Add(cardType);

                }


            }
            // Return the list as a array
            return cardDeck.ToArray();
          
        }

        

    
        public string[] Suit(string[] cardNames = null)
        {
            // Initialize Suits 
            if (cardNames == null)
            {
                cardNames = new string[] { "Spades", "Hearts", "Diamonds", "Clubs" };
            }
            // Return suits
            return cardNames;
        }

        public String[] deckOfCards( string suit) {

           // Create a array of all the cards in a blackjack game
           string[] cardTypes = { "Ace of ", "2 of ", "3 of ", "4 of ", "5 of ", "6 of ", "7 of ", "8 of ", "9 of ", "10 of ", "Jack of ", "Queen of ", "King of " };
            // Create a list of cards
            List<String> cards = new List<String>();
            //Loop trough all cards at the suit and add it to the list
            foreach (String cardType in cardTypes) {
                cards.Add( cardType + suit);
            }
            
            //return the list
            return cards.ToArray();

}

 
    }
}   