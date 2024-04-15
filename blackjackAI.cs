namespace BlackJackOOP
{
    internal class blackjackAI
    {
        public bool checkGameStatus(int playerIndex, int dupe) {
            if(playerIndex == dupe)
            {
                return true;

            }
            return false;
        }

        public void handleWinner(List<PlayerBasic> players)
        {
            
            int highestPointCount = 0;
            int winnerIndex = 0;
            bool[] winners = new bool[players.Count];
            foreach(PlayerBasic player in players)
            {
                if(player.pointCount >= highestPointCount && player.pointCount <= 21)
                {
                    winners[winnerIndex] = true;
                    highestPointCount = player.pointCount;
                }
                winnerIndex++;
            }
            winnerIndex = 0;
            foreach(PlayerBasic player in players)
            {
                if (winners[winnerIndex] == true) {
                    Console.WriteLine(player.Name + " has won");
                }
                winnerIndex++;
            }
        }
        public void Handle_actions(Dealer dealer,PlayerBasic player, IDictionary<string, int> deckOfCards)
        {
           string[] actions = getActions(player);
            if(player.Name == "Dealer")
            {
               // Console.WriteLine(player.Name + " you have " + player.pointCount + " points");
                Console.Write("you can ");
                for(int i = 0; i < actions.Length; i++)
                {
                    Console.Write(actions[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("What whould you like to do: ");
                string playerAction = Console.ReadLine();
                foreach(string action in actions)
                {
                    if (action == playerAction && action == "hit")
                    {
                        player.Hit(dealer, deckOfCards, player);
                    }
                    else if (action == playerAction && action == "double")
                    {
                        player.Double(player);
                    }
                    else if(action == playerAction && action == "stand")
                    {
                        player.stand(player);
                    }
                }
                
            }
            else
            {
                if (checkIfDouble(player))
                {
                    player.Double(player);
                    return;
                }
                else if (player.pointCount >= 17)
                {
                    player.stand(player);
                    return;
                }
                else
                {

                    player.Hit(dealer, deckOfCards, player);
                }
            }
           

            

        }

        private string[] getActions(PlayerBasic player) {


            if (!player.hasStood)
            {
                string[] actions = ["hit"];
                List<string> actionsList = new List<string>(actions);
                if(player.Name == "Dealer" && player.pointCount > 17)
                {
                    actionsList.Add("stand");
                }
                else if (player.Name != "Dealer")
                {
                    actionsList.Add("stand");
                }
                if (checkIfDouble(player))
                {
                    actionsList.Add("double");                   
                }

                return actionsList.ToArray();
            }
            return [""];
        }

        private bool checkIfDouble(PlayerBasic player)
        {
            if (checkItemContains(player, [9, 10, 11]) && player.Cards.Keys.Contains("Ace Of"))
            {
                return true;
            }
            return false;
        }

        private bool checkItemContains(PlayerBasic player, int[] checkItems)
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