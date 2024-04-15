using System.Collections.Generic;
using System.Numerics;

namespace BlackJackOOP
{
    internal class Program
    {

 
        static void Main()
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

            foreach (PlayerBasic p in players)
            {

                

                dealer.giveOutCards(cardDeck.cardDeck, p);

                
                    Console.WriteLine("its " + p.Name + " turn");



                   if(!p.checkIfBust(p)) {

                       ai.Handle_actions(dealer, p, cardDeck.cardDeck);


                    }




                   Console.WriteLine(p.Name + " has " + p.pointCount + " points");



                
            }
            /*
           



            cardDeck.cardDeck = dealer.shuffleCards(cardDeck.cardDeck);



                foreach (KeyValuePair<string, int> cardType in cardDeck.cardDeck)
            {
                Console.Write(cardType.Key);
                Console.WriteLine(cardType.Value);

            }

            //give out two cards
          
          
            player.Hit(dealer, cardDeck.cardDeck, player);
            Console.WriteLine("Hit");
            //player.Hit(dealer, cardDeck.cardDeck, player);
            player.stand(player);


            Console.Write("Pointcount: ");
            Console.WriteLine(player.pointCount);
            Console.WriteLine("Chips: ");
            Console.Write(player.chips);

            Console.WriteLine("second loop");
            foreach (KeyValuePair<string, int> cardType in player.Cards)
            {
                Console.Write(cardType.Key);
                Console.WriteLine(cardType.Value);

            }









            //            foreach (string deck in deckOfCards)
            //            {
            //              Console.WriteLine(deck);
            //        }

            */
        }
    }
}
