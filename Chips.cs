using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace BlackJackOOP
{
    internal class Chips
    {
        public Chips(Dealer dealer)
        {
            Console.WriteLine("Set table chip count");
            int chipCount;
            string chipInput = Console.ReadLine();
            if (int.TryParse(chipInput, out chipCount))
            {
                dealer.tableChips = chipCount;
            }
            else
            {
                Console.WriteLine("Invalid chip count try again");
                Chips chips = new Chips(dealer);



            }


        }


        public void initializePlayerChipCount(List<PlayerBasic> players, Dealer dealer, handleGame calcGrade)
        {
            int playercount = players.Skip(1).Count();

            //give 10% of the table to the players
            int calcChips = dealer.tableChips / 10 / playercount;
            string dealerInput = dealer.checkAction("some chips");
            if (dealerInput == "1")
            {


                foreach (PlayerBasic player in players.Skip(1))
                {
                    player.chips = calcChips;
                }
            }
            else if (dealerInput == "2")
            {
                Console.WriteLine("dealer didn't give the players chips");
                calcGrade.calcGrade();

            }
            else
            {
                initializePlayerChipCount(players, dealer, calcGrade);
            }
        }



    }
}