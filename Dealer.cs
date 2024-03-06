namespace BlackJackOOP
{
    internal class Dealer : Player
    {
        public Dealer(string shuffle, string chips, string cards) {
           
        }

        public string[] shuffleCards(string [] deckOfCards)
        {
            return Random.Shuffle(deckOfCards); 
        }
}}