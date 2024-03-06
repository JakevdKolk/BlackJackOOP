namespace BlackJackOOP
{
    internal class Dealer : Player
    {
        public Dealer() {
           
        }

        public string[] shuffleCards(string [] deckOfCards)
        {


             Random rng = new Random();

            for (int i = 0; i < deckOfCards.Length; i++)
            {
                int k = rng.Next(deckOfCards.Length);
                string temp = deckOfCards[i];
                deckOfCards[i] = deckOfCards[k];
                deckOfCards[k] = temp;
            }
            return deckOfCards;


         }
}}