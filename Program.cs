namespace BlackJackOOP
{
    internal class Program
    {
        static void Main()
        {
            CardDeck cardDeck = new CardDeck();
            string[] deckOfCards = cardDeck.InitializeDeck();


            

            foreach (string deck in deckOfCards)
            {
                Console.WriteLine(deck);
            }


        }
    }
}
