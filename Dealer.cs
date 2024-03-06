namespace BlackJackOOP
{
    internal class Dealer : Player
    {
        public Dealer() {
           
        }

        public string[] shuffleCards(string [] deckOfCards)
        {

            //Get random method from C#
             Random rng = new Random();
            //Loop trough each item in deckOfCards
            for (int i = 0; i < deckOfCards.Length; i++)
            {
                //Randomize the list of cards
                int k = rng.Next(deckOfCards.Length);
                string temp = deckOfCards[i];
                deckOfCards[i] = deckOfCards[k];
                deckOfCards[k] = temp;
            }
            return deckOfCards;


         }
}}