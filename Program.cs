namespace BlackJackOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BlackjackSetup setup = new BlackjackSetup();
            List<PlayerBasic> players = setup.blackjackUserOptions();
            blackjackAI ai = new blackjackAI();

            CardDeck cardDeck = new CardDeck();

            //Initialze dealer
            Dealer dealer = new Dealer();
            cardDeck.initializeDeck();

            Chips chips = new Chips(dealer);

            chips.initializePlayerChipCount(players, dealer);

            cardDeck.cardDeck = dealer.shuffleCards(cardDeck.cardDeck);
            bool allPlayersStood = false;
            int playerCount = players.Count;
            int playersWhoHaveStood = 0;
            int[] dupes = new int[playerCount];
            dealer.giveOutFirstCard(cardDeck, players);
            Console.WriteLine("The table has " + dealer.tableChips + " chips");
            while (allPlayersStood == false) {
                int playersIndex = 0;
                foreach (PlayerBasic p in players)
            {



                    if (playerCount == playersWhoHaveStood)
                    {
                        ai.handleWinner(players , dealer);
                        allPlayersStood = true;
                        break;
                    }
                    if (ai.checkGameStatus(playersIndex, dupes[playersIndex]))
                    {
                        dupes[playersIndex] = playersIndex;
                        playersWhoHaveStood++;
                    }
      
                
                    Console.WriteLine("its " + p.Name + " turn");



                    if (!p.checkIfBust(p))
                    {

                        ai.Handle_actions(dealer, p, cardDeck.cardDeck);


                    }
                    




                   Console.WriteLine(p.Name + " has " + p.pointCount + " points");


                    playersIndex++;
                
            }
            }
         
        }
    }
}
