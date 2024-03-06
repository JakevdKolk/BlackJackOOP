using System.Numerics;

namespace BlackJackOOP
{
    internal class Program
    {
        static void Main()
        {
            CardDeck cardDeck = new CardDeck();
            string[] deckOfCards = cardDeck.InitializeDeck();
           
            Player player = new Player();
            Dealer dealer = new Dealer();
            dealer.shuffleCards(deckOfCards);





            foreach (string deck in deckOfCards)
            {
                Console.WriteLine(deck);
            }


        }
    }
}
