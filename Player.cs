using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackOOP
{
    internal class PlayerBasic
    {

        public string Name { get; set; }
        public IDictionary<string, int> Cards { get; set; }

        public IDictionary<string, int> secondHand { get; set; }

        public int pointCount  {get; set;}
                
        private bool hasStood { get; set; }

        public int chips { get; set; }
        public PlayerBasic() {
            secondHand = new Dictionary<string, int>();
        }


      
      public void Hit(Dealer dealer, IDictionary<string, int> deckOfCards, PlayerBasic player)
        {
            Console.WriteLine("The player has hit!!");
            dealer.giveOutCards(deckOfCards, player);
            checkPointCount(player);

        }
        public void stand(PlayerBasic player) {

            
            Console.WriteLine("The player has stood!!");
            checkPointCount(player);
            player.hasStood = true;

        }
        //voeg hier chips aan toe
        public void Double(PlayerBasic player)
        {
            Console.WriteLine("The player has doubled!!");
            checkPointCount(player);
            player.pointCount = player.pointCount + player.pointCount;
            // double the chip count

        }
        public bool checkIfDouble(PlayerBasic player)
        {
            if (player.checkItemContains(player, [9, 10, 11]) && player.Cards.Keys.Contains("Ace Of"))
            {
                return true;
            }
            return false;
        }
   
        public bool checkItemContains(PlayerBasic player , int[] checkItems)
        {

            foreach(int item in checkItems)
            {
                if (player.Cards.Values.Contains(item))
                {
                    return true;
                }
            }
            return false;

        }

        public bool checkIfSplit(PlayerBasic player)
        {
            foreach (KeyValuePair<string, int> cardType in player.Cards)
            {
                foreach (KeyValuePair<string, int> checkCardType in player.Cards)
                {
                    if (cardType.Key == checkCardType.Key)
                    {
                        secondHand.Add(cardType.Key, cardType.Value);

                        return true;
                    }
                }

            }
            return false;
        }

           /* public void Split(PlayerBasic player)
        {


            
        }*/
        public bool checkIfSecondHand(PlayerBasic player)
        {
            Console.WriteLine(player.secondHand);
            if(player.secondHand != null)
            {
                return true;
            }
            return false;
        }
        public bool checkIfBust(PlayerBasic player)
        {
            if (player.pointCount > 21)
            {
                Console.WriteLine("You lost!!!");
                return true;
            }
           
            return false;
        }
        private void checkPointCount(PlayerBasic player)
        {

            Console.Write("point count is ");
            Console.WriteLine(player.pointCount);
        }
    }
}
