using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace BlackJackOOP
{


    internal class CardDeck
    {


        public IDictionary<string, int> cardDeck { get; set; } = new Dictionary<string, int>();
        // Initialze card deck
        public void initializeDeck()
        {

            // Get suits
            string[] suits = suit();

            // Loop trough all suits
           // List<String> cardDeck = new List<String>();

            foreach (String suit in suits) {
                //Get cards
                IDictionary<string,int> cardTypes = deckOfCards(suit);
                // Loop trough all the cards and add them to the list
                foreach (KeyValuePair<string, int> cardType in cardTypes)
                {
                    cardDeck.Add(cardType.Key, cardType.Value);

                }


            }
          
        }

        

    
        private string[] suit(string[] cardNames = null)
        {
            // Initialize Suits 
            if (cardNames == null)
            {
                cardNames = new string[] { "Spades", "Hearts", "Diamonds", "Clubs" };
            }
            // Return suits
            return cardNames;
        }

        private IDictionary<String, int> deckOfCards( string suit) {

           // Create a array of all the cards in a blackjack game
           string[] cardTypes = { "Ace of ", "2 of ", "3 of ", "4 of ", "5 of ", "6 of ", "7 of ", "8 of ", "9 of ", "10 of ", "Jack of ", "Queen of ", "King of " };
            // Create a list of cards
            int points = 1;
            IDictionary<String, int> cards = new Dictionary<String, int>();
            //Loop trough all cards at the suit and add it to the list
            foreach (String cardType in cardTypes) {
                if(cardType == "Ace of")
                {
                    points = 11;
                    cards.Add(cardType + suit, points);
                    points = 1;

                }
                else if(points <= 10)
                {
                    cards.Add(cardType + suit, points);
                }
                else
                {
                    cards.Add(cardType + suit, 10);
                }
                points++;
            }
            

            //return the list
            return cards;

}

 
    }
}   