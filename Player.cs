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

        public int pointCount  {get; set;}
                
        private bool hasStood { get; set; }

        public int chips { get; set; }
        public PlayerBasic() {
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
            if (!player.checkIfBust(player))
            {
                Console.Write("point count is ");
                Console.WriteLine(player.pointCount);
            }
      

        }
    }
}
