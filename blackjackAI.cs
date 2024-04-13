namespace BlackJackOOP
{
    internal class blackjackAI
    {

        public void Handle_actions(Dealer dealer,PlayerBasic player, IDictionary<string, int> deckOfCards)
        {

            if (checkIfDouble(player))
            {
                player.Double(player);
                 return;
            }
            else if(player.pointCount >= 17) {
                player.stand(player);
                return;
            }
            else
            {
                
                player.Hit(dealer, deckOfCards, player);
            }

            

        }

        public bool checkIfDouble(PlayerBasic player)
        {
            if (checkItemContains(player, [9, 10, 11]) && player.Cards.Keys.Contains("Ace Of"))
            {
                return true;
            }
            return false;
        }

        public bool checkItemContains(PlayerBasic player, int[] checkItems)
        {

            foreach (int item in checkItems)
            {
                if (player.Cards.Values.Contains(item))
                {
                    return true;
                }
            }
            return false;

        }
    }

    
}